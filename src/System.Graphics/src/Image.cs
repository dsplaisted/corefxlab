using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Graphics
{
    public class Image
    {
        ManagedGDImage _gdImage;

        public Image(int width, int height, bool trueColor = false)
        {
            _gdImage = new ManagedGDImage(width, height, trueColor);
        }

        private Image(ManagedGDImage managedImage)
        {
            _gdImage = managedImage;
        }

        public int Width
        {
            get { return _gdImage.im.sx; }
        }

        public int Height
        {
            get { return _gdImage.im.sy; }
        }

        public bool IsTrueColor
        {
            get { return _gdImage.im.trueColor != 0; }
        }

        public ImageColor AllocateColor(int r, int g, int b, int alpha=NativeConstants.gdAlphaOpaque)
        {
            using (_gdImage.PrepareForMarshal())
            {
                int iColor = NativeMethods.gdImageColorAllocateAlpha(ref _gdImage.im, r, g, b, alpha);
                return new ImageColor(iColor);
            }
        }

        public void FillRectangle(int x1, int y1, int x2, int y2, ImageColor color)
        {
            using (_gdImage.PrepareForMarshal())
            {
                NativeMethods.gdImageFilledRectangle(ref _gdImage.im, x1, y1, x2, y2, color.ColorIndex);
            }
        }

        public void DrawRectangle(int x1, int y1, int x2, int y2, ImageColor color)
        {
            using (_gdImage.PrepareForMarshal())
            {
                NativeMethods.gdImageRectangle(ref _gdImage.im, x1, y1, x2, y2, color.ColorIndex);
            }
        }

        public void DrawEllipse(int cx, int cy, int width, int height, ImageColor color)
        {
            using (_gdImage.PrepareForMarshal())
            {
                NativeMethods.gdImageEllipse(ref _gdImage.im, cx, cy, width, height, color.ColorIndex);
            }
        }

        public Image Resize(int newWidth, int newHeight)
        {
            Image ret = new Image(newWidth, newHeight, IsTrueColor);

            using (_gdImage.PrepareForMarshal())
            using (ret._gdImage.PrepareForMarshal())
            {
                NativeMethods.gdImageCopyResized(ref ret._gdImage.im, ref _gdImage.im, 0, 0, 0, 0, newWidth, newHeight, Width, Height);
            }

            return ret;

        }

        public static Image FromPng(Stream stream)
        {
            IntPtr pNativeImage = IntPtr.Zero;
            try
            {
                var wrapper = new gdStreamWrapper(stream);
                pNativeImage = NativeMethods.gdImageCreateFromPngCtx(ref wrapper.IOCallbacks);

                var managedImage = ManagedGDImage.CopyFrom(pNativeImage);
                var ret = new Image(managedImage);
                return ret;
            }
            finally
            {
                if (pNativeImage != IntPtr.Zero)
                {
                    NativeMethods.gdImageDestroy(pNativeImage);
                }
            }
        }

        public void WritePng(Stream stream)
        {
            using (_gdImage.PrepareForMarshal())
            {
                var wrapper = new gdStreamWrapper(stream);
                NativeMethods.gdImagePngCtx(ref _gdImage.im, ref wrapper.IOCallbacks);
            }
        }
    }
}
