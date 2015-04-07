using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//  TODO:
//  - Support jpeg, gif, and bmp formats
//  - More operations
//  - Fonts?

namespace System.Graphics
{
    //  http://stackoverflow.com/questions/15544818/non-blitable-error-on-a-blitable-type
    //  Blittability reference: https://msdn.microsoft.com/en-us/library/75dwhxf7.aspx
    public class ManagedGDImage
    {
        internal gdImageStruct im;

        internal byte[][] _pixels;
        internal int[][] _trueColorPixels;

        object _lockObject = new object();
        int _marshallingRefCount = 0;
        ImageMarshaller _marshaller = null;

        public ManagedGDImage(int sx, int sy, bool trueColor = false)
        {
            im = new gdImageStruct();

            if (!trueColor)
            {
                _pixels = new byte[sy][];
                for (int i = 0; i < sy; i++)
                {
                    _pixels[i] = new byte[sx];
                }

                im.sx = sx;
                im.sy = sy;

                im.transparent = -1;
                im.thick = 1;

                unsafe
                {
                    fixed (int* pOpen = im.open)
                    {
                        for (int i = 0; (i < NativeConstants.gdMaxColors); i++)
                        {
                            pOpen[i] = 1;
                        }
                    }
                }

                im.cx2 = im.sx - 1;
                im.cy2 = im.sy - 1;
            }
            else
            {
                //  True color
                _trueColorPixels = new int[sy][];
                for (int i = 0; i < sy; i++)
                {
                    _trueColorPixels[i] = new int[sx];
                }

                im.sx = sx;
                im.sy = sy;

                im.transparent = -1;
                im.trueColor = 1;

                im.alphaBlendingFlag = 1;
                im.thick = 1;

                im.cx2 = im.sx - 1;
                im.cy2 = im.sy - 1;

                im.res_x = NativeConstants.GD_RESOLUTION;
                im.res_y = NativeConstants.GD_RESOLUTION;

                im.interpolation_id = gdInterpolationMethod.GD_BILINEAR_FIXED;
            }
        }

        internal static ManagedGDImage CopyFrom(IntPtr pNativeImage)
        {
            gdImageStruct nativeImage = (gdImageStruct)Marshal.PtrToStructure(pNativeImage, typeof(gdImageStruct));

            var ret = new ManagedGDImage(nativeImage.sx, nativeImage.sy, nativeImage.trueColor != 0);
            ret.im = nativeImage;
            ret.SetPointersToNull();

            if (nativeImage.trueColor == 0)
            {
                IntPtr[] rowPointers = new IntPtr[nativeImage.sy];
                Marshal.Copy(nativeImage.pixels, rowPointers, 0, nativeImage.sy);
                for (int i=0; i<nativeImage.sy; i++)
                {
                    Marshal.Copy(rowPointers[i], ret._pixels[i], 0, nativeImage.sx);
                }
            }
            else
            {
                IntPtr[] rowPointers = new IntPtr[nativeImage.sy];
                Marshal.Copy(nativeImage.tpixels, rowPointers, 0, nativeImage.sy);
                for (int i=0; i<nativeImage.sy; i++)
                {
                    Marshal.Copy(rowPointers[i], ret._trueColorPixels[i], 0, nativeImage.sx);
                }
            }

            if (nativeImage.styleLength > 0)
            {
                throw new NotImplementedException("Style");
            }

            if (nativeImage.brush != IntPtr.Zero)
            {
                throw new NotImplementedException("Brush");
            }

            if (nativeImage.tile != IntPtr.Zero)
            {
                throw new NotImplementedException("Tile");
            }

            if (nativeImage.polyAllocated > 0)
            {
                throw new NotImplementedException("polyInts");
            }

            return ret;
        }

        void SetPointersToNull()
        {
            im.pixels = IntPtr.Zero;
            im.tpixels = IntPtr.Zero;
            im.style = IntPtr.Zero;
            im.brush = IntPtr.Zero;
            im.tile = IntPtr.Zero;
            im.polyInts = IntPtr.Zero;
        }

        public IDisposable PrepareForMarshal()
        {
            lock (_lockObject)
            {
                if (_marshallingRefCount == 0)
                {
                    _marshaller = new ImageMarshaller(this);
                }

                _marshallingRefCount++;

                return new MarshalHandle(this);
            }
        }

        void DecrementRefCount()
        {
            lock (_lockObject)
            {
                if (_marshallingRefCount > 0)
                {
                    _marshallingRefCount--;
                    if (_marshallingRefCount == 0)
                    {
                        _marshaller.Dispose();
                        _marshaller = null;
                    }
                }
                else
                {
                    throw new InvalidOperationException("Image ref count is less than zero");
                }
            }
        }

        private class MarshalHandle : IDisposable
        {
            ManagedGDImage _image;

            public MarshalHandle(ManagedGDImage image)
            {
                _image = image;
            }

            public void Dispose()
            {
                _image.DecrementRefCount();
            }
        }


        private class ImageMarshaller : IDisposable
        {
            ManagedGDImage _image;

            GCHandle[] _rowHandles;
            IntPtr[] _rowPointers;

            GCHandle _rowPointerHandle;

            public ImageMarshaller(ManagedGDImage image)
            {
                _image = image;

                _rowHandles = new GCHandle[_image.im.sy];
                _rowPointers = new IntPtr[_image.im.sy];
                if (image.im.trueColor == 0)
                {
                    for (int i = 0; i < _image.im.sy; i++)
                    {
                        _rowHandles[i] = GCHandle.Alloc(_image._pixels[i], GCHandleType.Pinned);
                        _rowPointers[i] = _rowHandles[i].AddrOfPinnedObject();
                    }

                    _rowPointerHandle = GCHandle.Alloc(_rowPointers, GCHandleType.Pinned);
                    _image.im.pixels = _rowPointerHandle.AddrOfPinnedObject();
                }
                else
                {
                    for (int i = 0; i < _image.im.sy;i++)
                    {
                        _rowHandles[i] = GCHandle.Alloc(_image._trueColorPixels[i], GCHandleType.Pinned);
                        _rowPointers[i] = _rowHandles[i].AddrOfPinnedObject();
                    }

                    _rowPointerHandle = GCHandle.Alloc(_rowPointers, GCHandleType.Pinned);
                    _image.im.tpixels = _rowPointerHandle.AddrOfPinnedObject();
                }

                if (image.im.styleLength > 0)
                {
                    throw new NotImplementedException("Style");
                }

                if (image.im.brush != IntPtr.Zero)
                {
                    throw new NotImplementedException("Brush");
                }

                if (image.im.tile != IntPtr.Zero)
                {
                    throw new NotImplementedException("Tile");
                }
            }

            public void Dispose()
            {
                if (_rowHandles != null)
                {
                    for (int i = 0; i < _image.im.sy; i++)
                    {
                        _rowHandles[i].Free();
                    }
                }

                if (_rowPointerHandle != null)
                {
                    _rowPointerHandle.Free();
                }

                _image.SetPointersToNull();

                //  TODO: gdImageClone doesn't seem to allocate new polyInts array before copying to it.  Is this a bug?
                if (_image.im.polyAllocated > 0)
                {
                    throw new NotImplementedException("Polyfill not supported");
                }
            }
        }

    }
}
