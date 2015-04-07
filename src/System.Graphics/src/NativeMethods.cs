
using System;
using System.Runtime.InteropServices;
public partial class NativeConstants {
    
    /// GD_H -> 1
    public const int GD_H = 1;
    
    /// GD_MAJOR_VERSION -> 2
    public const int GD_MAJOR_VERSION = 2;
    
    /// GD_MINOR_VERSION -> 1
    public const int GD_MINOR_VERSION = 1;
    
    /// GD_RELEASE_VERSION -> 1
    public const int GD_RELEASE_VERSION = 1;
    
    /// GD_EXTRA_VERSION -> ""
    public const string GD_EXTRA_VERSION = "";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// GDXXX_VERSION_STR -> "(mjr,mnr,rev,ext) mjr "." mnr "." rev ext"
    /// Error generating expression: Expression is not parsable.  Treating value as a raw string
    public const string GDXXX_VERSION_STR = "\"(mjr,mnr,rev,ext) mjr \".\" mnr \".\" rev ext\"";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// GDXXX_STR -> "(s) GDXXX_SSTR(s)"
    public const string GDXXX_STR = "(s) GDXXX_SSTR(s)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// GDXXX_SSTR -> "(s) #s"
    public const string GDXXX_SSTR = "(s) #s";
    
    /// GD_VERSION_STRING -> GDXXX_VERSION_STR(GDXXX_STR(GD_MAJOR_VERSION),                                            GDXXX_STR(GD_MINOR_VERSION),                                            GDXXX_STR(GD_RELEASE_VERSION),                                          GD_EXTRA_VERSION)
    /// Error generating expression: Error generating function call.  Operation not implemented
    public const string GD_VERSION_STRING = "GDXXX_VERSION_STR(GDXXX_STR(GD_MAJOR_VERSION),                                   " +
        "         GDXXX_STR(GD_MINOR_VERSION),                                           " +
        " GDXXX_STR(GD_RELEASE_VERSION),                                          GD_EXTR" +
        "A_VERSION)";
    
    /// BGD_EXPORT_DATA_PROT -> __declspec(dllimport)
    /// Error generating expression: Error generating function call.  Operation not implemented
    public const string BGD_EXPORT_DATA_PROT = "__declspec(dllimport)";
    
    /// BGD_STDCALL -> __stdcall
    /// Error generating expression: Value __stdcall is not resolved
    public const string BGD_STDCALL = "__stdcall";
    
    /// BGD_EXPORT_DATA_IMPL -> 
    /// Error generating expression: Value cannot be null.
    ///Parameter name: node
    public const string BGD_EXPORT_DATA_IMPL = "";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// BGD_DECLARE -> "(rt) BGD_EXPORT_DATA_PROT rt BGD_STDCALL"
    public const string BGD_DECLARE = "(rt) BGD_EXPORT_DATA_PROT rt BGD_STDCALL";
    
    /// _ALLOW_KEYWORD_MACROS -> 
    /// Error generating expression: Value cannot be null.
    ///Parameter name: node
    public const string _ALLOW_KEYWORD_MACROS = "";
    
    /// strcasecmp -> _stricmp
    /// Error generating expression: Value _stricmp is not resolved
    public const string strcasecmp = "_stricmp";
    
    /// snprintf -> _snprintf
    /// Error generating expression: Value _snprintf is not resolved
    public const string snprintf = "_snprintf";
    
    /// GD_IO_H -> 1
    public const int GD_IO_H = 1;
    
    /// gdMaxColors -> 256
    public const int gdMaxColors = 256;
    
    /// gdAlphaMax -> 127
    public const int gdAlphaMax = 127;
    
    /// gdAlphaOpaque -> 0
    public const int gdAlphaOpaque = 0;
    
    /// gdAlphaTransparent -> 127
    public const int gdAlphaTransparent = 127;
    
    /// gdRedMax -> 255
    public const int gdRedMax = 255;
    
    /// gdGreenMax -> 255
    public const int gdGreenMax = 255;
    
    /// gdBlueMax -> 255
    public const int gdBlueMax = 255;
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdTrueColorGetAlpha -> "(c) (((c) & 0x7F000000) >> 24)"
    public const string gdTrueColorGetAlpha = "(c) (((c) & 0x7F000000) >> 24)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdTrueColorGetRed -> "(c) (((c) & 0xFF0000) >> 16)"
    public const string gdTrueColorGetRed = "(c) (((c) & 0xFF0000) >> 16)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdTrueColorGetGreen -> "(c) (((c) & 0x00FF00) >> 8)"
    public const string gdTrueColorGetGreen = "(c) (((c) & 0x00FF00) >> 8)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdTrueColorGetBlue -> "(c) ((c) & 0x0000FF)"
    public const string gdTrueColorGetBlue = "(c) ((c) & 0x0000FF)";
    
    /// gdEffectReplace -> 0
    public const int gdEffectReplace = 0;
    
    /// gdEffectAlphaBlend -> 1
    public const int gdEffectAlphaBlend = 1;
    
    /// gdEffectNormal -> 2
    public const int gdEffectNormal = 2;
    
    /// gdEffectOverlay -> 3
    public const int gdEffectOverlay = 3;
    
    /// gdEffectMultiply -> 4
    public const int gdEffectMultiply = 4;
    
    /// GD_TRUE -> 1
    public const int GD_TRUE = 1;
    
    /// GD_FALSE -> 0
    public const int GD_FALSE = 0;
    
    /// GD_EPSILON -> 1e-6
    /// Error generating expression: Value 1e is not resolved
    public const string GD_EPSILON = "1e-6";
    
    /// M_PI -> 3.14159265358979323846
    public const float M_PI = 3.141593F;
    
    /// gdDashSize -> 4
    public const int gdDashSize = 4;
    
    /// gdStyled -> (-2)
    public const int gdStyled = -2;
    
    /// gdBrushed -> (-3)
    public const int gdBrushed = -3;
    
    /// gdStyledBrushed -> (-4)
    public const int gdStyledBrushed = -4;
    
    /// gdTiled -> (-5)
    public const int gdTiled = -5;
    
    /// gdTransparent -> (-6)
    public const int gdTransparent = -6;
    
    /// gdAntiAliased -> (-7)
    public const int gdAntiAliased = -7;
    
    /// gdImageCreatePalette -> gdImageCreate
    /// Error generating expression: Value gdImageCreate is not resolved
    public const string gdImageCreatePalette = "gdImageCreate";
    
    /// gdFTEX_LINESPACE -> 1
    public const int gdFTEX_LINESPACE = 1;
    
    /// gdFTEX_CHARMAP -> 2
    public const int gdFTEX_CHARMAP = 2;
    
    /// gdFTEX_RESOLUTION -> 4
    public const int gdFTEX_RESOLUTION = 4;
    
    /// gdFTEX_DISABLE_KERNING -> 8
    public const int gdFTEX_DISABLE_KERNING = 8;
    
    /// gdFTEX_XSHOW -> 16
    public const int gdFTEX_XSHOW = 16;
    
    /// gdFTEX_FONTPATHNAME -> 32
    public const int gdFTEX_FONTPATHNAME = 32;
    
    /// gdFTEX_FONTCONFIG -> 64
    public const int gdFTEX_FONTCONFIG = 64;
    
    /// gdFTEX_RETURNFONTPATHNAME -> 128
    public const int gdFTEX_RETURNFONTPATHNAME = 128;
    
    /// gdFTEX_Unicode -> 0
    public const int gdFTEX_Unicode = 0;
    
    /// gdFTEX_Shift_JIS -> 1
    public const int gdFTEX_Shift_JIS = 1;
    
    /// gdFTEX_Big5 -> 2
    public const int gdFTEX_Big5 = 2;
    
    /// gdFTEX_Adobe_Custom -> 3
    public const int gdFTEX_Adobe_Custom = 3;
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdTrueColor -> "(r,g,b) (((r) << 16) + 
    ///			      ((g) << 8) +  
    ///			      (b))"
    public const string gdTrueColor = "(r,g,b) (((r) << 16) + \r\n\t\t\t      ((g) << 8) +  \r\n\t\t\t      (b))";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdTrueColorAlpha -> "(r,g,b,a) (((a) << 24) + 
    ///				      ((r) << 16) + 
    ///				      ((g) << 8) +  
    ///				      (b))"
    public const string gdTrueColorAlpha = "(r,g,b,a) (((a) << 24) + \r\n\t\t\t\t      ((r) << 16) + \r\n\t\t\t\t      ((g) << 8) +  \r\n\t\t" +
        "\t\t      (b))";
    
    /// gdArc -> 0
    public const int gdArc = 0;
    
    /// gdPie -> gdArc
    public const int gdPie = NativeConstants.gdArc;
    
    /// gdChord -> 1
    public const int gdChord = 1;
    
    /// gdNoFill -> 2
    public const int gdNoFill = 2;
    
    /// gdEdged -> 4
    public const int gdEdged = 4;
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageTrueColor -> "(im) ((im)->trueColor)"
    public const string gdImageTrueColor = "(im) ((im)->trueColor)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageSX -> "(im) ((im)->sx)"
    public const string gdImageSX = "(im) ((im)->sx)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageSY -> "(im) ((im)->sy)"
    public const string gdImageSY = "(im) ((im)->sy)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageColorsTotal -> "(im) ((im)->colorsTotal)"
    public const string gdImageColorsTotal = "(im) ((im)->colorsTotal)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageRed -> "(im,c) ((im)->trueColor ? gdTrueColorGetRed(c) : 
    ///			   (im)->red[(c)])"
    public const string gdImageRed = "(im,c) ((im)->trueColor ? gdTrueColorGetRed(c) : \r\n\t\t\t   (im)->red[(c)])";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageGreen -> "(im,c) ((im)->trueColor ? gdTrueColorGetGreen(c) : 
    ///			     (im)->green[(c)])"
    public const string gdImageGreen = "(im,c) ((im)->trueColor ? gdTrueColorGetGreen(c) : \r\n\t\t\t     (im)->green[(c)])";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageBlue -> "(im,c) ((im)->trueColor ? gdTrueColorGetBlue(c) : 
    ///			    (im)->blue[(c)])"
    public const string gdImageBlue = "(im,c) ((im)->trueColor ? gdTrueColorGetBlue(c) : \r\n\t\t\t    (im)->blue[(c)])";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageAlpha -> "(im,c) ((im)->trueColor ? gdTrueColorGetAlpha(c) : 
    ///			     (im)->alpha[(c)])"
    public const string gdImageAlpha = "(im,c) ((im)->trueColor ? gdTrueColorGetAlpha(c) : \r\n\t\t\t     (im)->alpha[(c)])";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageGetTransparent -> "(im) ((im)->transparent)"
    public const string gdImageGetTransparent = "(im) ((im)->transparent)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageGetInterlaced -> "(im) ((im)->interlace)"
    public const string gdImageGetInterlaced = "(im) ((im)->interlace)";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImagePalettePixel -> "(im,x,y) (im)->pixels[(y)][(x)]"
    public const string gdImagePalettePixel = "(im,x,y) (im)->pixels[(y)][(x)]";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageTrueColorPixel -> "(im,x,y) (im)->tpixels[(y)][(x)]"
    public const string gdImageTrueColorPixel = "(im,x,y) (im)->tpixels[(y)][(x)]";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageResolutionX -> "(im) (im)->res_x"
    public const string gdImageResolutionX = "(im) (im)->res_x";
    
    /// Warning: Generation of Method Macros is not supported at this time
    /// gdImageResolutionY -> "(im) (im)->res_y"
    public const string gdImageResolutionY = "(im) (im)->res_y";
    
    /// GD2_CHUNKSIZE -> 128
    public const int GD2_CHUNKSIZE = 128;
    
    /// GD2_CHUNKSIZE_MIN -> 64
    public const int GD2_CHUNKSIZE_MIN = 64;
    
    /// GD2_CHUNKSIZE_MAX -> 4096
    public const int GD2_CHUNKSIZE_MAX = 4096;
    
    /// GD2_VERS -> 2
    public const int GD2_VERS = 2;
    
    /// GD2_ID -> "gd2"
    public const string GD2_ID = "gd2";
    
    /// GD2_FMT_RAW -> 1
    public const int GD2_FMT_RAW = 1;
    
    /// GD2_FMT_COMPRESSED -> 2
    public const int GD2_FMT_COMPRESSED = 2;
    
    /// GD_FLIP_HORINZONTAL -> 1
    public const int GD_FLIP_HORINZONTAL = 1;
    
    /// GD_FLIP_VERTICAL -> 2
    public const int GD_FLIP_VERTICAL = 2;
    
    /// GD_FLIP_BOTH -> 3
    public const int GD_FLIP_BOTH = 3;
    
    /// GD_CMP_IMAGE -> 1
    public const int GD_CMP_IMAGE = 1;
    
    /// GD_CMP_NUM_COLORS -> 2
    public const int GD_CMP_NUM_COLORS = 2;
    
    /// GD_CMP_COLOR -> 4
    public const int GD_CMP_COLOR = 4;
    
    /// GD_CMP_SIZE_X -> 8
    public const int GD_CMP_SIZE_X = 8;
    
    /// GD_CMP_SIZE_Y -> 16
    public const int GD_CMP_SIZE_Y = 16;
    
    /// GD_CMP_TRANSPARENT -> 32
    public const int GD_CMP_TRANSPARENT = 32;
    
    /// GD_CMP_BACKGROUND -> 64
    public const int GD_CMP_BACKGROUND = 64;
    
    /// GD_CMP_INTERLACE -> 128
    public const int GD_CMP_INTERLACE = 128;
    
    /// GD_CMP_TRUECOLOR -> 256
    public const int GD_CMP_TRUECOLOR = 256;
    
    /// GD_RESOLUTION -> 96
    public const int GD_RESOLUTION = 96;
    
    /// GDFX_H -> 1
    public const int GDFX_H = 1;
}

/// Return Type: int
///param0: gdIOCtx*
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int gdIOCtx_getC(IntPtr ctx);

/// Return Type: int
///param0: gdIOCtx*
///param1: void*
///param2: int
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int gdIOCtx_getBuf(IntPtr ctx, System.IntPtr buf, int wanted);

/// Return Type: void
///param0: gdIOCtx*
///param1: int
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void gdIOCtx_putC(IntPtr ctx, int ch);

/// Return Type: int
///param0: gdIOCtx*
///param1: void*
///param2: int
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int gdIOCtx_putBuf(IntPtr ctx, System.IntPtr buf, int wanted);

/// Return Type: int
///param0: gdIOCtx*
///param1: int
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int gdIOCtx_seek(IntPtr ctx, int pos);

/// Return Type: int
///param0: gdIOCtx*
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int gdIOCtx_tell(IntPtr ctx);

/// Return Type: void
///param0: gdIOCtx*
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void gdIOCtx_gd_free(ref gdIOCtx param0);

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdIOCtx {
    
    /// gdIOCtx_getC
    public gdIOCtx_getC getC;
    
    /// gdIOCtx_getBuf
    public gdIOCtx_getBuf getBuf;
    
    /// gdIOCtx_putC
    public gdIOCtx_putC putC;
    
    /// gdIOCtx_putBuf
    public gdIOCtx_putBuf putBuf;
    
    /// gdIOCtx_seek
    public gdIOCtx_seek seek;
    
    /// gdIOCtx_tell
    public gdIOCtx_tell tell;
    
    /// gdIOCtx_gd_free
    public gdIOCtx_gd_free gd_free;
    
    /// void*
    public System.IntPtr data;
}

public enum gdPaletteQuantizationMethod {
    
    /// GD_QUANT_DEFAULT -> 0
    GD_QUANT_DEFAULT = 0,
    
    /// GD_QUANT_JQUANT -> 1
    GD_QUANT_JQUANT = 1,
    
    /// GD_QUANT_NEUQUANT -> 2
    GD_QUANT_NEUQUANT = 2,
    
    /// GD_QUANT_LIQ -> 3
    GD_QUANT_LIQ = 3,
}

/// Return Type: double
///param0: double
public delegate double interpolation_method(double param0);

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
unsafe public struct gdImageStruct {
    
    /// unsigned char**
    public System.IntPtr pixels;
    
    /// int
    public int sx;
    
    /// int
    public int sy;
    
    /// int
    public int colorsTotal;
    
    /// int[256]
    //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=256, ArraySubType=System.Runtime.InteropServices.UnmanagedType.I4)]
    public fixed int red[NativeConstants.gdMaxColors];
    
    /// int[256]
    //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=256, ArraySubType=System.Runtime.InteropServices.UnmanagedType.I4)]
    public fixed int green[NativeConstants.gdMaxColors];
    
    /// int[256]
    //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I4)]
    public fixed int blue[NativeConstants.gdMaxColors];
    
    /// int[256]
    //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=256, ArraySubType=System.Runtime.InteropServices.UnmanagedType.I4)]
    public fixed int open[NativeConstants.gdMaxColors];
    
    /// int
    public int transparent;
    
    /// int*
    public System.IntPtr polyInts;
    
    /// int
    public int polyAllocated;
    
    /// gdImageStruct*
    public System.IntPtr brush;
    
    /// gdImageStruct*
    public System.IntPtr tile;
    
    /// int[256]
    //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=256, ArraySubType=System.Runtime.InteropServices.UnmanagedType.I4)]
    public fixed int brushColorMap[NativeConstants.gdMaxColors];
    
    /// int[256]
    //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=256, ArraySubType=System.Runtime.InteropServices.UnmanagedType.I4)]
    public fixed int tileColorMap[NativeConstants.gdMaxColors];
    
    /// int
    public int styleLength;
    
    /// int
    public int stylePos;
    
    /// int*
    public System.IntPtr style;
    
    /// int
    public int interlace;
    
    /// int
    public int thick;
    
    /// int[256]
    //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=256, ArraySubType=System.Runtime.InteropServices.UnmanagedType.I4)]
    public fixed int alpha[NativeConstants.gdMaxColors];
    
    /// int
    public int trueColor;
    
    /// int**
    public System.IntPtr tpixels;
    
    /// int
    public int alphaBlendingFlag;
    
    /// int
    public int saveAlphaFlag;
    
    /// int
    public int AA;
    
    /// int
    public int AA_color;
    
    /// int
    public int AA_dont_blend;
    
    /// int
    public int cx1;
    
    /// int
    public int cy1;
    
    /// int
    public int cx2;
    
    /// int
    public int cy2;
    
    /// unsigned int
    public uint res_x;
    
    /// unsigned int
    public uint res_y;
    
    /// int
    public int paletteQuantizationMethod;
    
    /// int
    public int paletteQuantizationSpeed;
    
    /// int
    public int paletteQuantizationMinQuality;
    
    /// int
    public int paletteQuantizationMaxQuality;
    
    /// gdInterpolationMethod->Anonymous_8fdb1b14_e01c_4fdc_9daf_7e192c545f1b
    public gdInterpolationMethod interpolation_id;
    
    /// interpolation_method
    //public interpolation_method interpolation;
    public IntPtr interpolation;
}

/// Return Type: void
///param0: int
///param1: char*
///param2: va_list->char*
public delegate void gdErrorMethod(int param0, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string param1, System.IntPtr param2);

/// Return Type: int
///context: void*
///buffer: char*
///len: int
public delegate int _source(System.IntPtr context, System.IntPtr buffer, int len);

/// Return Type: int
///im: gdImagePtr->gdImage*
///src: int
public delegate int gdCallbackImageColor(ref gdImageStruct im, int src);

/// Return Type: int
///context: void*
///buffer: char*
///len: int
public delegate int _sink(System.IntPtr context, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string buffer, int len);

public enum gdPixelateMode {
    
    GD_PIXELATE_UPPERLEFT,
    
    GD_PIXELATE_AVERAGE,
}

public enum gdCropMode {
    
    /// GD_CROP_DEFAULT -> 0
    GD_CROP_DEFAULT = 0,
    
    GD_CROP_TRANSPARENT,
    
    GD_CROP_BLACK,
    
    GD_CROP_WHITE,
    
    GD_CROP_SIDES,
    
    GD_CROP_THRESHOLD,
}

public enum gdInterpolationMethod {
    
    /// GD_DEFAULT -> 0
    GD_DEFAULT = 0,
    
    GD_BELL,
    
    GD_BESSEL,
    
    GD_BILINEAR_FIXED,
    
    GD_BICUBIC,
    
    GD_BICUBIC_FIXED,
    
    GD_BLACKMAN,
    
    GD_BOX,
    
    GD_BSPLINE,
    
    GD_CATMULLROM,
    
    GD_GAUSSIAN,
    
    GD_GENERALIZED_CUBIC,
    
    GD_HERMITE,
    
    GD_HAMMING,
    
    GD_HANNING,
    
    GD_MITCHELL,
    
    GD_NEAREST_NEIGHBOUR,
    
    GD_POWER,
    
    GD_QUADRATIC,
    
    GD_SINC,
    
    GD_TRIANGLE,
    
    GD_WEIGHTED4,
    
    /// GD_METHOD_COUNT -> 21
    GD_METHOD_COUNT = 21,
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdRect {
    
    /// int
    public int x;
    
    /// int
    public int y;
    
    /// int
    public int width;
    
    /// int
    public int height;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdSource {
    
    /// _source
    public _source AnonymousMember1;
    
    /// void*
    public System.IntPtr context;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdFTStringExtra {
    
    /// int
    public int flags;
    
    /// double
    public double linespacing;
    
    /// int
    public int charmap;
    
    /// int
    public int hdpi;
    
    /// int
    public int vdpi;
    
    /// char*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string xshow;
    
    /// char*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string fontpath;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdPoint {
    
    /// int
    public int x;
    
    /// int
    public int y;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdSink {
    
    /// _sink
    public _sink AnonymousMember1;
    
    /// void*
    public System.IntPtr context;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdScatter {
    
    /// int
    public int sub;
    
    /// int
    public int plus;
    
    /// unsigned int
    public uint num_colors;
    
    /// int*
    public System.IntPtr colors;
    
    /// unsigned int
    public uint seed;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct gdFont {
    
    /// int
    public int nchars;
    
    /// int
    public int offset;
    
    /// int
    public int w;
    
    /// int
    public int h;
    
    /// char*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string data;
}

public partial class NativeMethods
{

    /// Return Type: void
    ///w: int
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "Putword")]
    public static extern void Putword(int w, ref gdIOCtx ctx);


    /// Return Type: void
    ///c: int
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "Putchar")]
    public static extern void Putchar(int c, ref gdIOCtx ctx);


    /// Return Type: void
    ///c: char
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdPutC")]
    public static extern void gdPutC(byte c, ref gdIOCtx ctx);


    /// Return Type: int
    ///param0: void*
    ///param1: int
    ///param2: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdPutBuf")]
    public static extern int gdPutBuf(System.IntPtr param0, int param1, ref gdIOCtx param2);


    /// Return Type: void
    ///w: int
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdPutWord")]
    public static extern void gdPutWord(int w, ref gdIOCtx ctx);


    /// Return Type: void
    ///w: int
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdPutInt")]
    public static extern void gdPutInt(int w, ref gdIOCtx ctx);


    /// Return Type: int
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdGetC")]
    public static extern int gdGetC(ref gdIOCtx ctx);


    /// Return Type: int
    ///param0: void*
    ///param1: int
    ///param2: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdGetBuf")]
    public static extern int gdGetBuf(System.IntPtr param0, int param1, ref gdIOCtx param2);


    /// Return Type: int
    ///result: int*
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdGetByte")]
    public static extern int gdGetByte(ref int result, ref gdIOCtx ctx);


    /// Return Type: int
    ///result: int*
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdGetWord")]
    public static extern int gdGetWord(ref int result, ref gdIOCtx ctx);


    /// Return Type: int
    ///param0: short
    ///result: int*
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdGetWordLSB")]
    public static extern int gdGetWordLSB(short param0, ref int result, ref gdIOCtx ctx);


    /// Return Type: int
    ///result: int*
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdGetInt")]
    public static extern int gdGetInt(ref int result, ref gdIOCtx ctx);


    /// Return Type: int
    ///result: int*
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdGetIntLSB")]
    public static extern int gdGetIntLSB(ref int result, ref gdIOCtx ctx);


    /// Return Type: int
    ///ctx: gdIOCtx*
    ///offset: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdSeek")]
    public static extern int gdSeek(ref gdIOCtx ctx, int offset);


    /// Return Type: int
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdTell")]
    public static extern int gdTell(ref gdIOCtx ctx);


    /// Return Type: int
    ///dest: int
    ///src: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdAlphaBlend", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdAlphaBlend(int dest, int src);


    /// Return Type: int
    ///dest: int
    ///src: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdLayerOverlay", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdLayerOverlay(int dest, int src);


    /// Return Type: int
    ///dest: int
    ///src: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdLayerMultiply", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdLayerMultiply(int dest, int src);


    /// Return Type: void
    ///param0: gdErrorMethod
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdSetErrorMethod", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdSetErrorMethod(gdErrorMethod param0);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdClearErrorMethod", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdClearErrorMethod();


    /// Return Type: gdImagePtr->gdImage*
    ///sx: int
    ///sy: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreate(int sx, int sy);


    /// Return Type: gdImagePtr->gdImage*
    ///sx: int
    ///sy: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateTrueColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateTrueColor(int sx, int sy);


    /// Return Type: gdImagePtr->gdImage*
    ///in: gdIOCtxPtr->gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromPngCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromPngCtx(ref gdIOCtx @in);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromPngPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromPngPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///in: gdIOCtxPtr->gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGifCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGifCtx(ref gdIOCtx @in);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGifPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGifPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///infile: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromWBMPCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromWBMPCtx(ref gdIOCtx infile);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromWBMPPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromWBMPPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///infile: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromJpegCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromJpegCtx(ref gdIOCtx infile);


    /// Return Type: gdImagePtr->gdImage*
    ///infile: gdIOCtx*
    ///ignore_warning: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromJpegCtxEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromJpegCtxEx(ref gdIOCtx infile, int ignore_warning);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromJpegPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromJpegPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    ///ignore_warning: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromJpegPtrEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromJpegPtrEx(int size, System.IntPtr data, int ignore_warning);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromWebpPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromWebpPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///infile: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromWebpCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromWebpCtx(ref gdIOCtx infile);


    /// Return Type: gdImagePtr->gdImage*
    ///infile: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromTiffCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromTiffCtx(ref gdIOCtx infile);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromTiffPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromTiffPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///ctx: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromTgaCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromTgaCtx(ref gdIOCtx ctx);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromTgaPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromTgaPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromBmpPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromBmpPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///infile: gdIOCtxPtr->gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromBmpCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromBmpCtx(ref gdIOCtx infile);


    /// Return Type: gdImagePtr->gdImage*
    ///filename: char*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromFile", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromFile([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename);


    /// Return Type: gdImagePtr->gdImage*
    ///in: gdSourcePtr->Anonymous_fb0279fa_03bc_4043_9c82_95aee423fb86*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromPngSource", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromPngSource(ref gdSource @in);


    /// Return Type: gdImagePtr->gdImage*
    ///in: gdIOCtxPtr->gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGdCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGdCtx(ref gdIOCtx @in);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGdPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGdPtr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///in: gdIOCtxPtr->gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGd2Ctx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGd2Ctx(ref gdIOCtx @in);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGd2Ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGd2Ptr(int size, System.IntPtr data);


    /// Return Type: gdImagePtr->gdImage*
    ///in: gdIOCtxPtr->gdIOCtx*
    ///srcx: int
    ///srcy: int
    ///w: int
    ///h: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGd2PartCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGd2PartCtx(ref gdIOCtx @in, int srcx, int srcy, int w, int h);


    /// Return Type: gdImagePtr->gdImage*
    ///size: int
    ///data: void*
    ///srcx: int
    ///srcy: int
    ///w: int
    ///h: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromGd2PartPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromGd2PartPtr(int size, System.IntPtr data, int srcx, int srcy, int w, int h);


    /// Return Type: void
    ///image: gdImagePtr->gdImage*
    ///file_name: char*
    ///fg: int
    ///out: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageXbmCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageXbmCtx(ref gdImageStruct image, System.IntPtr file_name, int fg, ref gdIOCtx @out);


    /// Return Type: gdImagePtr->gdImage*
    ///filename: char*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreateFromXpm", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreateFromXpm(System.IntPtr filename);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageDestroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageDestroy(IntPtr im);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x: int
    ///y: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetPixel", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetPixel(ref gdImageStruct im, int x, int y, int color);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///x: int
    ///y: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGetPixel", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageGetPixel(ref gdImageStruct im, int x, int y);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///x: int
    ///y: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGetTrueColorPixel", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageGetTrueColorPixel(ref gdImageStruct im, int x, int y);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageAABlend", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageAABlend(ref gdImageStruct im);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x1: int
    ///y1: int
    ///x2: int
    ///y2: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageLine(ref gdImageStruct im, int x1, int y1, int x2, int y2, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x1: int
    ///y1: int
    ///x2: int
    ///y2: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageDashedLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageDashedLine(ref gdImageStruct im, int x1, int y1, int x2, int y2, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x1: int
    ///y1: int
    ///x2: int
    ///y2: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageRectangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageRectangle(ref gdImageStruct im, int x1, int y1, int x2, int y2, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x1: int
    ///y1: int
    ///x2: int
    ///y2: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFilledRectangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFilledRectangle(ref gdImageStruct im, int x1, int y1, int x2, int y2, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x1: int
    ///y1: int
    ///x2: int
    ///y2: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetClip", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetClip(ref gdImageStruct im, int x1, int y1, int x2, int y2);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x1P: int*
    ///y1P: int*
    ///x2P: int*
    ///y2P: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGetClip", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageGetClip(ref gdImageStruct im, ref int x1P, ref int y1P, ref int x2P, ref int y2P);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///res_x: int
    ///res_y: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetResolution", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetResolution(ref gdImageStruct im, int res_x, int res_y);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///x: int
    ///y: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageBoundsSafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageBoundsSafe(ref gdImageStruct im, int x, int y);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///f: gdFontPtr->gdFont*
    ///x: int
    ///y: int
    ///c: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageChar", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageChar(ref gdImageStruct im, ref gdFont f, int x, int y, int c, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///f: gdFontPtr->gdFont*
    ///x: int
    ///y: int
    ///c: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCharUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageCharUp(ref gdImageStruct im, ref gdFont f, int x, int y, int c, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///f: gdFontPtr->gdFont*
    ///x: int
    ///y: int
    ///s: unsigned char*
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageString", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageString(ref gdImageStruct im, ref gdFont f, int x, int y, System.IntPtr s, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///f: gdFontPtr->gdFont*
    ///x: int
    ///y: int
    ///s: unsigned char*
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageStringUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageStringUp(ref gdImageStruct im, ref gdFont f, int x, int y, System.IntPtr s, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///f: gdFontPtr->gdFont*
    ///x: int
    ///y: int
    ///s: unsigned short*
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageString16", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageString16(ref gdImageStruct im, ref gdFont f, int x, int y, ref ushort s, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///f: gdFontPtr->gdFont*
    ///x: int
    ///y: int
    ///s: unsigned short*
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageStringUp16", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageStringUp16(ref gdImageStruct im, ref gdFont f, int x, int y, ref ushort s, int color);


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdFontCacheSetup", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdFontCacheSetup();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdFontCacheShutdown", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdFontCacheShutdown();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdFreeFontCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdFreeFontCache();


    /// Return Type: char*
    ///im: gdImage*
    ///brect: int*
    ///fg: int
    ///fontlist: char*
    ///ptsize: double
    ///angle: double
    ///x: int
    ///y: int
    ///string: char*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageStringTTF", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageStringTTF(ref gdImageStruct im, ref int brect, int fg, System.IntPtr fontlist, double ptsize, double angle, int x, int y, System.IntPtr @string);


    /// Return Type: char*
    ///im: gdImage*
    ///brect: int*
    ///fg: int
    ///fontlist: char*
    ///ptsize: double
    ///angle: double
    ///x: int
    ///y: int
    ///string: char*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageStringFT", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageStringFT(ref gdImageStruct im, ref int brect, int fg, System.IntPtr fontlist, double ptsize, double angle, int x, int y, System.IntPtr @string);


    /// Return Type: int
    ///flag: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdFTUseFontConfig", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdFTUseFontConfig(int flag);


    /// Return Type: char*
    ///im: gdImage*
    ///brect: int*
    ///fg: int
    ///fontlist: char*
    ///ptsize: double
    ///angle: double
    ///x: int
    ///y: int
    ///string: char*
    ///strex: gdFTStringExtraPtr->Anonymous_71569dae_d912_48cb_91d5_f5146467614f*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageStringFTEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageStringFTEx(ref gdImageStruct im, ref int brect, int fg, System.IntPtr fontlist, double ptsize, double angle, int x, int y, System.IntPtr @string, ref gdFTStringExtra strex);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///p: gdPointPtr->Anonymous_3e2f7b83_c2ca_4f17_b92e_2b357cb5a67d*
    ///n: int
    ///c: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePolygon", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImagePolygon(ref gdImageStruct im, ref gdPoint p, int n, int c);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///p: gdPointPtr->Anonymous_3e2f7b83_c2ca_4f17_b92e_2b357cb5a67d*
    ///n: int
    ///c: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageOpenPolygon", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageOpenPolygon(ref gdImageStruct im, ref gdPoint p, int n, int c);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///p: gdPointPtr->Anonymous_3e2f7b83_c2ca_4f17_b92e_2b357cb5a67d*
    ///n: int
    ///c: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFilledPolygon", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFilledPolygon(ref gdImageStruct im, ref gdPoint p, int n, int c);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorAllocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorAllocate(IntPtr im, int r, int g, int b);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    ///a: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorAllocateAlpha", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorAllocateAlpha(ref gdImageStruct im, int r, int g, int b, int a);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorClosest", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorClosest(ref gdImageStruct im, int r, int g, int b);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    ///a: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorClosestAlpha", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorClosestAlpha(ref gdImageStruct im, int r, int g, int b, int a);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorClosestHWB", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorClosestHWB(ref gdImageStruct im, int r, int g, int b);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorExact", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorExact(ref gdImageStruct im, int r, int g, int b);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    ///a: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorExactAlpha", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorExactAlpha(ref gdImageStruct im, int r, int g, int b, int a);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorResolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorResolve(ref gdImageStruct im, int r, int g, int b);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///r: int
    ///g: int
    ///b: int
    ///a: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorResolveAlpha", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorResolveAlpha(ref gdImageStruct im, int r, int g, int b, int a);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorDeallocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageColorDeallocate(ref gdImageStruct im, int color);


    /// Return Type: gdImagePtr->gdImage*
    ///im: gdImagePtr->gdImage*
    ///ditherFlag: int
    ///colorsWanted: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCreatePaletteFromTrueColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCreatePaletteFromTrueColor(ref gdImageStruct im, int ditherFlag, int colorsWanted);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///ditherFlag: int
    ///colorsWanted: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageTrueColorToPalette", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageTrueColorToPalette(ref gdImageStruct im, int ditherFlag, int colorsWanted);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePaletteToTrueColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImagePaletteToTrueColor(ref gdImageStruct src);


    /// Return Type: int
    ///im1: gdImagePtr->gdImage*
    ///im2: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorMatch", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorMatch(ref gdImageStruct im1, ref gdImageStruct im2);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///method: int
    ///speed: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageTrueColorToPaletteSetMethod", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageTrueColorToPaletteSetMethod(ref gdImageStruct im, int method, int speed);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///min_quality: int
    ///max_quality: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageTrueColorToPaletteSetQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageTrueColorToPaletteSetQuality(ref gdImageStruct im, int min_quality, int max_quality);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorTransparent", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageColorTransparent(ref gdImageStruct im, int color);


    /// Return Type: void
    ///dst: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePaletteCopy", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImagePaletteCopy(ref gdImageStruct dst, ref gdImageStruct src);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///src: int
    ///dst: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorReplace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorReplace(ref gdImageStruct im, int src, int dst);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///src: int
    ///dst: int
    ///threshold: float
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorReplaceThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorReplaceThreshold(ref gdImageStruct im, int src, int dst, float threshold);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///len: int
    ///src: int*
    ///dst: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorReplaceArray", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorReplaceArray(ref gdImageStruct im, int len, ref int src, ref int dst);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///callback: gdCallbackImageColor
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColorReplaceCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColorReplaceCallback(ref gdImageStruct im, gdCallbackImageColor callback);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePngCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImagePngCtx(ref gdImageStruct im, ref gdIOCtx @out);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageGifCtx(ref gdImageStruct im, ref gdIOCtx @out);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageTiffPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageTiffPtr(ref gdImageStruct im, ref int size);


    /// Return Type: void
    ///image: gdImagePtr->gdImage*
    ///out: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageTiffCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageTiffCtx(ref gdImageStruct image, ref gdIOCtx @out);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    ///compression: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageBmpPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageBmpPtr(ref gdImageStruct im, ref int size, int compression);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdIOCtxPtr->gdIOCtx*
    ///compression: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageBmpCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageBmpCtx(ref gdImageStruct im, ref gdIOCtx @out, int compression);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdIOCtx*
    ///level: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePngCtxEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImagePngCtxEx(ref gdImageStruct im, ref gdIOCtx @out, int level);


    /// Return Type: void
    ///image: gdImagePtr->gdImage*
    ///fg: int
    ///out: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageWBMPCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageWBMPCtx(ref gdImageStruct image, int fg, ref gdIOCtx @out);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///filename: char*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFile", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageFile(ref gdImageStruct im, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename);


    /// Return Type: int
    ///filename: char*
    ///writing: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdSupportsFileType", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdSupportsFileType([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename, int writing);


    /// Return Type: void
    ///m: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdFree", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdFree(System.IntPtr m);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    ///fg: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageWBMPPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageWBMPPtr(ref gdImageStruct im, ref int size, int fg);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdIOCtx*
    ///quality: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageJpegCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageJpegCtx(ref gdImageStruct im, ref gdIOCtx @out, int quality);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    ///quality: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageJpegPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageJpegPtr(ref gdImageStruct im, ref int size, int quality);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageWebpPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageWebpPtr(ref gdImageStruct im, ref int size);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    ///quantization: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageWebpPtrEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageWebpPtrEx(ref gdImageStruct im, ref int size, int quantization);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///outfile: gdIOCtx*
    ///quantization: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageWebpCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageWebpCtx(ref gdImageStruct im, ref gdIOCtx outfile, int quantization);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdIOCtx*
    ///GlobalCM: int
    ///Loops: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifAnimBeginCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageGifAnimBeginCtx(ref gdImageStruct im, ref gdIOCtx @out, int GlobalCM, int Loops);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdIOCtx*
    ///LocalCM: int
    ///LeftOfs: int
    ///TopOfs: int
    ///Delay: int
    ///Disposal: int
    ///previm: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifAnimAddCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageGifAnimAddCtx(ref gdImageStruct im, ref gdIOCtx @out, int LocalCM, int LeftOfs, int TopOfs, int Delay, int Disposal, ref gdImageStruct previm);


    /// Return Type: void
    ///out: gdIOCtx*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifAnimEndCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageGifAnimEndCtx(ref gdIOCtx @out);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    ///GlobalCM: int
    ///Loops: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifAnimBeginPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageGifAnimBeginPtr(ref gdImageStruct im, ref int size, int GlobalCM, int Loops);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    ///LocalCM: int
    ///LeftOfs: int
    ///TopOfs: int
    ///Delay: int
    ///Disposal: int
    ///previm: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifAnimAddPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageGifAnimAddPtr(ref gdImageStruct im, ref int size, int LocalCM, int LeftOfs, int TopOfs, int Delay, int Disposal, ref gdImageStruct previm);


    /// Return Type: void*
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifAnimEndPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageGifAnimEndPtr(ref int size);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///out: gdSinkPtr->Anonymous_42287495_27a5_460a_add3_401f4a65cc58*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePngToSink", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImagePngToSink(ref gdImageStruct im, ref gdSink @out);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGifPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageGifPtr(ref gdImageStruct im, ref int size);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePngPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImagePngPtr(ref gdImageStruct im, ref int size);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    ///level: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePngPtrEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImagePngPtrEx(ref gdImageStruct im, ref int size, int level);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGdPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageGdPtr(ref gdImageStruct im, ref int size);


    /// Return Type: void*
    ///im: gdImagePtr->gdImage*
    ///cs: int
    ///fmt: int
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGd2Ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageGd2Ptr(ref gdImageStruct im, int cs, int fmt, ref int size);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///cx: int
    ///cy: int
    ///w: int
    ///h: int
    ///s: int
    ///e: int
    ///color: int
    ///style: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFilledArc", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFilledArc(ref gdImageStruct im, int cx, int cy, int w, int h, int s, int e, int color, int style);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///cx: int
    ///cy: int
    ///w: int
    ///h: int
    ///s: int
    ///e: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageArc", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageArc(ref gdImageStruct im, int cx, int cy, int w, int h, int s, int e, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///cx: int
    ///cy: int
    ///w: int
    ///h: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageEllipse", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageEllipse(ref gdImageStruct im, int cx, int cy, int w, int h, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///cx: int
    ///cy: int
    ///w: int
    ///h: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFilledEllipse", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFilledEllipse(ref gdImageStruct im, int cx, int cy, int w, int h, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x: int
    ///y: int
    ///border: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFillToBorder", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFillToBorder(ref gdImageStruct im, int x, int y, int border, int color);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///x: int
    ///y: int
    ///color: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFill", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFill(ref gdImageStruct im, int x, int y, int color);


    /// Return Type: void
    ///dst: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///dstX: int
    ///dstY: int
    ///srcX: int
    ///srcY: int
    ///w: int
    ///h: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCopy", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageCopy(ref gdImageStruct dst, ref gdImageStruct src, int dstX, int dstY, int srcX, int srcY, int w, int h);


    /// Return Type: void
    ///dst: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///dstX: int
    ///dstY: int
    ///srcX: int
    ///srcY: int
    ///w: int
    ///h: int
    ///pct: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCopyMerge", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageCopyMerge(ref gdImageStruct dst, ref gdImageStruct src, int dstX, int dstY, int srcX, int srcY, int w, int h, int pct);


    /// Return Type: void
    ///dst: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///dstX: int
    ///dstY: int
    ///srcX: int
    ///srcY: int
    ///w: int
    ///h: int
    ///pct: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCopyMergeGray", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageCopyMergeGray(ref gdImageStruct dst, ref gdImageStruct src, int dstX, int dstY, int srcX, int srcY, int w, int h, int pct);


    /// Return Type: void
    ///dst: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///dstX: int
    ///dstY: int
    ///srcX: int
    ///srcY: int
    ///dstW: int
    ///dstH: int
    ///srcW: int
    ///srcH: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCopyResized", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageCopyResized(ref gdImageStruct dst, ref gdImageStruct src, int dstX, int dstY, int srcX, int srcY, int dstW, int dstH, int srcW, int srcH);


    /// Return Type: void
    ///dst: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///dstX: int
    ///dstY: int
    ///srcX: int
    ///srcY: int
    ///dstW: int
    ///dstH: int
    ///srcW: int
    ///srcH: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCopyResampled", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageCopyResampled(ref gdImageStruct dst, ref gdImageStruct src, int dstX, int dstY, int srcX, int srcY, int dstW, int dstH, int srcW, int srcH);


    /// Return Type: void
    ///dst: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///dstX: double
    ///dstY: double
    ///srcX: int
    ///srcY: int
    ///srcWidth: int
    ///srcHeight: int
    ///angle: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCopyRotated", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageCopyRotated(ref gdImageStruct dst, ref gdImageStruct src, double dstX, double dstY, int srcX, int srcY, int srcWidth, int srcHeight, int angle);


    /// Return Type: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageClone", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageClone(ref gdImageStruct src);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///brush: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetBrush", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetBrush(ref gdImageStruct im, ref gdImageStruct brush);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///tile: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetTile", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetTile(ref gdImageStruct im, ref gdImageStruct tile);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///c: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetAntiAliased", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetAntiAliased(ref gdImageStruct im, int c);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///c: int
    ///dont_blend: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetAntiAliasedDontBlend", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetAntiAliasedDontBlend(ref gdImageStruct im, int c, int dont_blend);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///style: int*
    ///noOfPixels: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetStyle", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetStyle(ref gdImageStruct im, ref int style, int noOfPixels);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///thickness: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetThickness", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSetThickness(ref gdImageStruct im, int thickness);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///interlaceArg: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageInterlace", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageInterlace(ref gdImageStruct im, int interlaceArg);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///alphaBlendingArg: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageAlphaBlending", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageAlphaBlending(ref gdImageStruct im, int alphaBlendingArg);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///saveAlphaArg: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSaveAlpha", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSaveAlpha(ref gdImageStruct im, int saveAlphaArg);


    /// Return Type: gdImagePtr->gdImage*
    ///im: gdImagePtr->gdImage*
    ///max_color: int
    ///sample_factor: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageNeuQuant", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageNeuQuant(ref gdImageStruct im, int max_color, int sample_factor);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///block_size: int
    ///mode: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImagePixelate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImagePixelate(ref gdImageStruct im, int block_size, int mode);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///sub: int
    ///plus: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageScatter", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageScatter(ref gdImageStruct im, int sub, int plus);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///sub: int
    ///plus: int
    ///colors: int*
    ///num_colors: unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageScatterColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageScatterColor(ref gdImageStruct im, int sub, int plus, ref int colors, uint num_colors);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///s: gdScatterPtr->Anonymous_9112695e_b89e_48c1_9687_9c6e43a64246*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageScatterEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageScatterEx(ref gdImageStruct im, ref gdScatter s);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///weight: float
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSmooth", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageSmooth(ref gdImageStruct im, float weight);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageMeanRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageMeanRemoval(ref gdImageStruct im);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageEmboss", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageEmboss(ref gdImageStruct im);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGaussianBlur", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageGaussianBlur(ref gdImageStruct im);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageEdgeDetectQuick", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageEdgeDetectQuick(ref gdImageStruct src);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSelectiveBlur", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageSelectiveBlur(ref gdImageStruct src);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    ///red: int
    ///green: int
    ///blue: int
    ///alpha: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageColor(ref gdImageStruct src, int red, int green, int blue, int alpha);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    ///contrast: double
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageContrast", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageContrast(ref gdImageStruct src, double contrast);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    ///brightness: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageBrightness", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageBrightness(ref gdImageStruct src, int brightness);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGrayScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageGrayScale(ref gdImageStruct src);


    /// Return Type: int
    ///src: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageNegate", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageNegate(ref gdImageStruct src);


    /// Return Type: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///radius: int
    ///sigma: double
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCopyGaussianBlurred", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCopyGaussianBlurred(ref gdImageStruct src, int radius, double sigma);


    /// Return Type: gdIOCtx*
    ///size: int
    ///data: void*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdNewDynamicCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdNewDynamicCtx(int size, System.IntPtr data);


    /// Return Type: gdIOCtx*
    ///size: int
    ///data: void*
    ///freeFlag: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdNewDynamicCtxEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdNewDynamicCtxEx(int size, System.IntPtr data, int freeFlag);


    /// Return Type: gdIOCtx*
    ///in: gdSourcePtr->Anonymous_fb0279fa_03bc_4043_9c82_95aee423fb86*
    ///out: gdSinkPtr->Anonymous_42287495_27a5_460a_add3_401f4a65cc58*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdNewSSCtx", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdNewSSCtx(ref gdSource @in, ref gdSink @out);


    /// Return Type: void*
    ///ctx: gdIOCtx*
    ///size: int*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdDPExtractData", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdDPExtractData(ref gdIOCtx ctx, ref int size);


    /// Return Type: int
    ///im1: gdImagePtr->gdImage*
    ///im2: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCompare", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageCompare(ref gdImageStruct im1, ref gdImageStruct im2);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFlipHorizontal", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFlipHorizontal(ref gdImageStruct im);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFlipVertical", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFlipVertical(ref gdImageStruct im);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageFlipBoth", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageFlipBoth(ref gdImageStruct im);


    /// Return Type: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///crop: gdRect*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCrop", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCrop(ref gdImageStruct src, ref gdRect crop);


    /// Return Type: gdImagePtr->gdImage*
    ///im: gdImagePtr->gdImage*
    ///mode: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCropAuto", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCropAuto(ref gdImageStruct im, int mode);


    /// Return Type: gdImagePtr->gdImage*
    ///im: gdImagePtr->gdImage*
    ///color: int
    ///threshold: float
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageCropThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageCropThreshold(ref gdImageStruct im, int color, float threshold);


    /// Return Type: int
    ///im: gdImagePtr->gdImage*
    ///id: gdInterpolationMethod->Anonymous_8fdb1b14_e01c_4fdc_9daf_7e192c545f1b
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSetInterpolationMethod", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdImageSetInterpolationMethod(ref gdImageStruct im, gdInterpolationMethod id);


    /// Return Type: gdInterpolationMethod->Anonymous_8fdb1b14_e01c_4fdc_9daf_7e192c545f1b
    ///im: gdImagePtr->gdImage*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageGetInterpolationMethod", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern gdInterpolationMethod gdImageGetInterpolationMethod(ref gdImageStruct im);


    /// Return Type: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///new_width: int
    ///new_height: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageScale(ref gdImageStruct src, int new_width, int new_height);


    /// Return Type: gdImagePtr->gdImage*
    ///src: gdImagePtr->gdImage*
    ///angle: float
    ///bgcolor: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageRotateInterpolated", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageRotateInterpolated(ref gdImageStruct src, float angle, int bgcolor);


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdMajorVersion", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdMajorVersion();


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdMinorVersion", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdMinorVersion();


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdReleaseVersion", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern int gdReleaseVersion();


    /// Return Type: char*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdExtraVersion", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdExtraVersion();


    /// Return Type: char*
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdVersionString", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdVersionString();


    /// Return Type: gdImagePtr->gdImage*
    ///im: gdImagePtr->gdImage*
    ///radius: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSquareToCircle", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageSquareToCircle(ref gdImageStruct im, int radius);


    /// Return Type: char*
    ///im: gdImagePtr->gdImage*
    ///cx: int
    ///cy: int
    ///radius: double
    ///textRadius: double
    ///fillPortion: double
    ///font: char*
    ///points: double
    ///top: char*
    ///bottom: char*
    ///fgcolor: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageStringFTCircle", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern System.IntPtr gdImageStringFTCircle(ref gdImageStruct im, int cx, int cy, double radius, double textRadius, double fillPortion, System.IntPtr font, double points, System.IntPtr top, System.IntPtr bottom, int fgcolor);


    /// Return Type: void
    ///im: gdImagePtr->gdImage*
    ///pct: int
    [System.Runtime.InteropServices.DllImportAttribute("libgd.dll", EntryPoint = "gdImageSharpen", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
    public static extern void gdImageSharpen(ref gdImageStruct im, int pct);

}
