using System;
using System.Runtime.InteropServices;
namespace Cider.Bindings.OpenGL.ES
{
    /// <summary>
    /// OpenGL ES 3.0 API bindings.
    /// </summary>
    public static unsafe partial class Gl
    {
        private const string Lib = "GLESv2";
#if BROWSER
        private const string EntryPointPrefix = "export_";
#else
        private const string EntryPointPrefix = "";
#endif
        #region GLES 2.0 Types

        public const int GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const int GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const int GL_COLOR_BUFFER_BIT = 0x00004000;
        public const int GL_FALSE = 0;
        public const int GL_TRUE = 1;
        public const int GL_POINTS = 0x0000;
        public const int GL_LINES = 0x0001;
        public const int GL_LINE_LOOP = 0x0002;
        public const int GL_LINE_STRIP = 0x0003;
        public const int GL_TRIANGLES = 0x0004;
        public const int GL_TRIANGLE_STRIP = 0x0005;
        public const int GL_TRIANGLE_FAN = 0x0006;

        public const int GL_ZERO = 0;
        public const int GL_ONE = 1;
        public const int GL_SRC_COLOR = 0x0300;
        public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const int GL_SRC_ALPHA = 0x0302;
        public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const int GL_DST_ALPHA = 0x0304;
        public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;
        public const int GL_DST_COLOR = 0x0306;
        public const int GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const int GL_SRC_ALPHA_SATURATE = 0x0308;
        public const int GL_FUNC_ADD = 0x8006;
        public const int GL_BLEND_EQUATION = 0x8009;
        public const int GL_BLEND_EQUATION_RGB = 0x8009;
        public const int GL_BLEND_EQUATION_ALPHA = 0x883D;
        public const int GL_FUNC_SUBTRACT = 0x800A;
        public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
        public const int GL_BLEND_DST_RGB = 0x80C8;
        public const int GL_BLEND_SRC_RGB = 0x80C9;
        public const int GL_BLEND_DST_ALPHA = 0x80CA;
        public const int GL_BLEND_SRC_ALPHA = 0x80CB;
        public const int GL_CONSTANT_COLOR = 0x8001;
        public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const int GL_CONSTANT_ALPHA = 0x8003;
        public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const int GL_BLEND_COLOR = 0x8005;
        public const int GL_ARRAY_BUFFER = 0x8892;
        public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
        public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
        public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public const int GL_STREAM_DRAW = 0x88E0;
        public const int GL_STATIC_DRAW = 0x88E4;
        public const int GL_DYNAMIC_DRAW = 0x88E8;
        public const int GL_BUFFER_SIZE = 0x8764;
        public const int GL_BUFFER_USAGE = 0x8765;
        public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
        public const int GL_FRONT = 0x0404;
        public const int GL_BACK = 0x0405;
        public const int GL_FRONT_AND_BACK = 0x0408;
        public const int GL_TEXTURE_2D = 0x0DE1;
        public const int GL_CULL_FACE = 0x0B44;
        public const int GL_BLEND = 0x0BE2;
        public const int GL_DITHER = 0x0BD0;
        public const int GL_STENCIL_TEST = 0x0B90;
        public const int GL_DEPTH_TEST = 0x0B71;
        public const int GL_SCISSOR_TEST = 0x0C11;
        public const int GL_POLYGON_OFFSET_FILL = 0x8037;
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const int GL_SAMPLE_COVERAGE = 0x80A0;
        public const int GL_NO_ERROR = 0;
        public const int GL_INVALID_ENUM = 0x0500;
        public const int GL_INVALID_VALUE = 0x0501;
        public const int GL_INVALID_OPERATION = 0x0502;
        public const int GL_OUT_OF_MEMORY = 0x0505;
        public const int GL_CW = 0x0900;
        public const int GL_CCW = 0x0901;
        public const int GL_LINE_WIDTH = 0x0B21;
        public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const int GL_CULL_FACE_MODE = 0x0B45;
        public const int GL_FRONT_FACE = 0x0B46;
        public const int GL_DEPTH_RANGE = 0x0B70;
        public const int GL_DEPTH_WRITEMASK = 0x0B72;
        public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;
        public const int GL_DEPTH_FUNC = 0x0B74;
        public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;
        public const int GL_STENCIL_FUNC = 0x0B92;
        public const int GL_STENCIL_FAIL = 0x0B94;
        public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const int GL_STENCIL_REF = 0x0B97;
        public const int GL_STENCIL_VALUE_MASK = 0x0B93;
        public const int GL_STENCIL_WRITEMASK = 0x0B98;
        public const int GL_STENCIL_BACK_FUNC = 0x8800;
        public const int GL_STENCIL_BACK_FAIL = 0x8801;
        public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const int GL_STENCIL_BACK_REF = 0x8CA3;
        public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const int GL_VIEWPORT = 0x0BA2;
        public const int GL_SCISSOR_BOX = 0x0C10;
        public const int GL_COLOR_CLEAR_VALUE = 0x0C22;
        public const int GL_COLOR_WRITEMASK = 0x0C23;
        public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
        public const int GL_PACK_ALIGNMENT = 0x0D05;
        public const int GL_MAX_TEXTURE_SIZE = 0x0D33;
        public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;
        public const int GL_SUBPIXEL_BITS = 0x0D50;
        public const int GL_RED_BITS = 0x0D52;
        public const int GL_GREEN_BITS = 0x0D53;
        public const int GL_BLUE_BITS = 0x0D54;
        public const int GL_ALPHA_BITS = 0x0D55;
        public const int GL_DEPTH_BITS = 0x0D56;
        public const int GL_STENCIL_BITS = 0x0D57;
        public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
        public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
        public const int GL_TEXTURE_BINDING_2D = 0x8069;
        public const int GL_SAMPLE_BUFFERS = 0x80A8;
        public const int GL_SAMPLES = 0x80A9;
        public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public const int GL_DONT_CARE = 0x1100;
        public const int GL_FASTEST = 0x1101;
        public const int GL_NICEST = 0x1102;
        public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
        public const int GL_BYTE = 0x1400;
        public const int GL_UNSIGNED_BYTE = 0x1401;
        public const int GL_SHORT = 0x1402;
        public const int GL_UNSIGNED_SHORT = 0x1403;
        public const int GL_INT = 0x1404;
        public const int GL_UNSIGNED_INT = 0x1405;
        public const int GL_FLOAT = 0x1406;
        public const int GL_FIXED = 0x140C;
        public const int GL_DEPTH_COMPONENT = 0x1902;
        public const int GL_ALPHA = 0x1906;
        public const int GL_RGB = 0x1907;
        public const int GL_RGBA = 0x1908;
        public const int GL_LUMINANCE = 0x1909;
        public const int GL_LUMINANCE_ALPHA = 0x190A;
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const int GL_FRAGMENT_SHADER = 0x8B30;
        public const int GL_VERTEX_SHADER = 0x8B31;
        public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
        public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
        public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const int GL_SHADER_TYPE = 0x8B4F;
        public const int GL_DELETE_STATUS = 0x8B80;
        public const int GL_LINK_STATUS = 0x8B82;
        public const int GL_VALIDATE_STATUS = 0x8B83;
        public const int GL_ATTACHED_SHADERS = 0x8B85;
        public const int GL_ACTIVE_UNIFORMS = 0x8B86;
        public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
        public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
        public const int GL_CURRENT_PROGRAM = 0x8B8D;
        public const int GL_NEVER = 0x0200;
        public const int GL_LESS = 0x0201;
        public const int GL_EQUAL = 0x0202;
        public const int GL_LEQUAL = 0x0203;
        public const int GL_GREATER = 0x0204;
        public const int GL_NOTEQUAL = 0x0205;
        public const int GL_GEQUAL = 0x0206;
        public const int GL_ALWAYS = 0x0207;
        public const int GL_KEEP = 0x1E00;
        public const int GL_REPLACE = 0x1E01;
        public const int GL_INCR = 0x1E02;
        public const int GL_DECR = 0x1E03;
        public const int GL_INVERT = 0x150A;
        public const int GL_INCR_WRAP = 0x8507;
        public const int GL_DECR_WRAP = 0x8508;
        public const int GL_VENDOR = 0x1F00;
        public const int GL_RENDERER = 0x1F01;
        public const int GL_VERSION = 0x1F02;
        public const int GL_EXTENSIONS = 0x1F03;
        public const int GL_NEAREST = 0x2600;
        public const int GL_LINEAR = 0x2601;
        public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
        public const int GL_TEXTURE_MAG_FILTER = 0x2800;
        public const int GL_TEXTURE_MIN_FILTER = 0x2801;
        public const int GL_TEXTURE_WRAP_S = 0x2802;
        public const int GL_TEXTURE_WRAP_T = 0x2803;
        public const int GL_TEXTURE = 0x1702;
        public const int GL_TEXTURE_CUBE_MAP = 0x8513;
        public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public const int GL_TEXTURE0 = 0x84C0;
        public const int GL_TEXTURE1 = 0x84C1;
        public const int GL_TEXTURE2 = 0x84C2;
        public const int GL_TEXTURE3 = 0x84C3;
        public const int GL_TEXTURE4 = 0x84C4;
        public const int GL_TEXTURE5 = 0x84C5;
        public const int GL_TEXTURE6 = 0x84C6;
        public const int GL_TEXTURE7 = 0x84C7;
        public const int GL_TEXTURE8 = 0x84C8;
        public const int GL_TEXTURE9 = 0x84C9;
        public const int GL_TEXTURE10 = 0x84CA;
        public const int GL_TEXTURE11 = 0x84CB;
        public const int GL_TEXTURE12 = 0x84CC;
        public const int GL_TEXTURE13 = 0x84CD;
        public const int GL_TEXTURE14 = 0x84CE;
        public const int GL_TEXTURE15 = 0x84CF;
        public const int GL_TEXTURE16 = 0x84D0;
        public const int GL_TEXTURE17 = 0x84D1;
        public const int GL_TEXTURE18 = 0x84D2;
        public const int GL_TEXTURE19 = 0x84D3;
        public const int GL_TEXTURE20 = 0x84D4;
        public const int GL_TEXTURE21 = 0x84D5;
        public const int GL_TEXTURE22 = 0x84D6;
        public const int GL_TEXTURE23 = 0x84D7;
        public const int GL_TEXTURE24 = 0x84D8;
        public const int GL_TEXTURE25 = 0x84D9;
        public const int GL_TEXTURE26 = 0x84DA;
        public const int GL_TEXTURE27 = 0x84DB;
        public const int GL_TEXTURE28 = 0x84DC;
        public const int GL_TEXTURE29 = 0x84DD;
        public const int GL_TEXTURE30 = 0x84DE;
        public const int GL_TEXTURE31 = 0x84DF;
        public const int GL_ACTIVE_TEXTURE = 0x84E0;
        public const int GL_REPEAT = 0x2901;
        public const int GL_CLAMP_TO_EDGE = 0x812F;
        public const int GL_MIRRORED_REPEAT = 0x8370;
        public const int GL_FLOAT_VEC2 = 0x8B50;
        public const int GL_FLOAT_VEC3 = 0x8B51;
        public const int GL_FLOAT_VEC4 = 0x8B52;
        public const int GL_INT_VEC2 = 0x8B53;
        public const int GL_INT_VEC3 = 0x8B54;
        public const int GL_INT_VEC4 = 0x8B55;
        public const int GL_BOOL = 0x8B56;
        public const int GL_BOOL_VEC2 = 0x8B57;
        public const int GL_BOOL_VEC3 = 0x8B58;
        public const int GL_BOOL_VEC4 = 0x8B59;
        public const int GL_FLOAT_MAT2 = 0x8B5A;
        public const int GL_FLOAT_MAT3 = 0x8B5B;
        public const int GL_FLOAT_MAT4 = 0x8B5C;
        public const int GL_SAMPLER_2D = 0x8B5E;
        public const int GL_SAMPLER_CUBE = 0x8B60;
        public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const int GL_COMPILE_STATUS = 0x8B81;
        public const int GL_INFO_LOG_LENGTH = 0x8B84;
        public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
        public const int GL_SHADER_COMPILER = 0x8DFA;
        public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
        public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        public const int GL_LOW_FLOAT = 0x8DF0;
        public const int GL_MEDIUM_FLOAT = 0x8DF1;
        public const int GL_HIGH_FLOAT = 0x8DF2;
        public const int GL_LOW_INT = 0x8DF3;
        public const int GL_MEDIUM_INT = 0x8DF4;
        public const int GL_HIGH_INT = 0x8DF5;
        public const int GL_FRAMEBUFFER = 0x8D40;
        public const int GL_RENDERBUFFER = 0x8D41;
        public const int GL_RGBA4 = 0x8056;
        public const int GL_RGB5_A1 = 0x8057;
        public const int GL_RGB565 = 0x8D62;
        public const int GL_DEPTH_COMPONENT16 = 0x81A5;
        public const int GL_STENCIL_INDEX8 = 0x8D48;
        public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
        public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
        public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
        public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
        public const int GL_DEPTH_ATTACHMENT = 0x8D00;
        public const int GL_STENCIL_ATTACHMENT = 0x8D20;
        public const int GL_NONE = 0;
        public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
        public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
        public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
        public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;

        #endregion

        #region GLES 3.0 Constants

        public const int GL_READ_BUFFER = 0x0C02;
        public const int GL_UNPACK_ROW_LENGTH = 0x0CF2;
        public const int GL_UNPACK_SKIP_ROWS = 0x0CF3;
        public const int GL_UNPACK_SKIP_PIXELS = 0x0CF4;
        public const int GL_PACK_ROW_LENGTH = 0x0D02;
        public const int GL_PACK_SKIP_ROWS = 0x0D03;
        public const int GL_PACK_SKIP_PIXELS = 0x0D04;
        public const int GL_COLOR = 0x1800;
        public const int GL_DEPTH = 0x1801;
        public const int GL_STENCIL = 0x1802;
        public const int GL_RED = 0x1903;
        public const int GL_RGB8 = 0x8051;
        public const int GL_RGBA8 = 0x8058;
        public const int GL_RGB10_A2 = 0x8059;
        public const int GL_TEXTURE_BINDING_3D = 0x806A;
        public const int GL_UNPACK_SKIP_IMAGES = 0x806D;
        public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;
        public const int GL_TEXTURE_3D = 0x806F;
        public const int GL_TEXTURE_WRAP_R = 0x8072;
        public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;
        public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;
        public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;
        public const int GL_TEXTURE_MIN_LOD = 0x813A;
        public const int GL_TEXTURE_MAX_LOD = 0x813B;
        public const int GL_TEXTURE_BASE_LEVEL = 0x813C;
        public const int GL_TEXTURE_MAX_LEVEL = 0x813D;
        public const int GL_MIN = 0x8007;
        public const int GL_MAX = 0x8008;
        public const int GL_DEPTH_COMPONENT24 = 0x81A6;
        public const int GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
        public const int GL_TEXTURE_COMPARE_MODE = 0x884C;
        public const int GL_TEXTURE_COMPARE_FUNC = 0x884D;
        public const int GL_CURRENT_QUERY = 0x8865;
        public const int GL_QUERY_RESULT = 0x8866;
        public const int GL_QUERY_RESULT_AVAILABLE = 0x8867;
        public const int GL_BUFFER_MAPPED = 0x88BC;
        public const int GL_BUFFER_MAP_POINTER = 0x88BD;
        public const int GL_STREAM_READ = 0x88E1;
        public const int GL_STREAM_COPY = 0x88E2;
        public const int GL_STATIC_READ = 0x88E5;
        public const int GL_STATIC_COPY = 0x88E6;
        public const int GL_DYNAMIC_READ = 0x88E9;
        public const int GL_DYNAMIC_COPY = 0x88EA;
        public const int GL_MAX_DRAW_BUFFERS = 0x8824;
        public const int GL_DRAW_BUFFER0 = 0x8825;
        public const int GL_DRAW_BUFFER1 = 0x8826;
        public const int GL_DRAW_BUFFER2 = 0x8827;
        public const int GL_DRAW_BUFFER3 = 0x8828;
        public const int GL_DRAW_BUFFER4 = 0x8829;
        public const int GL_DRAW_BUFFER5 = 0x882A;
        public const int GL_DRAW_BUFFER6 = 0x882B;
        public const int GL_DRAW_BUFFER7 = 0x882C;
        public const int GL_DRAW_BUFFER8 = 0x882D;
        public const int GL_DRAW_BUFFER9 = 0x882E;
        public const int GL_DRAW_BUFFER10 = 0x882F;
        public const int GL_DRAW_BUFFER11 = 0x8830;
        public const int GL_DRAW_BUFFER12 = 0x8831;
        public const int GL_DRAW_BUFFER13 = 0x8832;
        public const int GL_DRAW_BUFFER14 = 0x8833;
        public const int GL_DRAW_BUFFER15 = 0x8834;
        public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
        public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
        public const int GL_SAMPLER_3D = 0x8B5F;
        public const int GL_SAMPLER_2D_SHADOW = 0x8B62;
        public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
        public const int GL_PIXEL_PACK_BUFFER = 0x88EB;
        public const int GL_PIXEL_UNPACK_BUFFER = 0x88EC;
        public const int GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        public const int GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        public const int GL_FLOAT_MAT2x3 = 0x8B65;
        public const int GL_FLOAT_MAT2x4 = 0x8B66;
        public const int GL_FLOAT_MAT3x2 = 0x8B67;
        public const int GL_FLOAT_MAT3x4 = 0x8B68;
        public const int GL_FLOAT_MAT4x2 = 0x8B69;
        public const int GL_FLOAT_MAT4x3 = 0x8B6A;
        public const int GL_SRGB = 0x8C40;
        public const int GL_SRGB8 = 0x8C41;
        public const int GL_SRGB8_ALPHA8 = 0x8C43;
        public const int GL_COMPARE_REF_TO_TEXTURE = 0x884E;
        public const int GL_MAJOR_VERSION = 0x821B;
        public const int GL_MINOR_VERSION = 0x821C;
        public const int GL_NUM_EXTENSIONS = 0x821D;
        public const int GL_RGBA32F = 0x8814;
        public const int GL_RGB32F = 0x8815;
        public const int GL_RGBA16F = 0x881A;
        public const int GL_RGB16F = 0x881B;
        public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
        public const int GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
        public const int GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
        public const int GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
        public const int GL_MAX_VARYING_COMPONENTS = 0x8B4B;
        public const int GL_TEXTURE_2D_ARRAY = 0x8C1A;
        public const int GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
        public const int GL_R11F_G11F_B10F = 0x8C3A;
        public const int GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
        public const int GL_RGB9_E5 = 0x8C3D;
        public const int GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
        public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
        public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        public const int GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
        public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
        public const int GL_RASTERIZER_DISCARD = 0x8C89;
        public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
        public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
        public const int GL_INTERLEAVED_ATTRIBS = 0x8C8C;
        public const int GL_SEPARATE_ATTRIBS = 0x8C8D;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
        public const int GL_RGBA32UI = 0x8D70;
        public const int GL_RGB32UI = 0x8D71;
        public const int GL_RGBA16UI = 0x8D76;
        public const int GL_RGB16UI = 0x8D77;
        public const int GL_RGBA8UI = 0x8D7C;
        public const int GL_RGB8UI = 0x8D7D;
        public const int GL_RGBA32I = 0x8D82;
        public const int GL_RGB32I = 0x8D83;
        public const int GL_RGBA16I = 0x8D88;
        public const int GL_RGB16I = 0x8D89;
        public const int GL_RGBA8I = 0x8D8E;
        public const int GL_RGB8I = 0x8D8F;
        public const int GL_RED_INTEGER = 0x8D94;
        public const int GL_RGB_INTEGER = 0x8D98;
        public const int GL_RGBA_INTEGER = 0x8D99;
        public const int GL_SAMPLER_2D_ARRAY = 0x8DC1;
        public const int GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
        public const int GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
        public const int GL_UNSIGNED_INT_VEC2 = 0x8DC6;
        public const int GL_UNSIGNED_INT_VEC3 = 0x8DC7;
        public const int GL_UNSIGNED_INT_VEC4 = 0x8DC8;
        public const int GL_INT_SAMPLER_2D = 0x8DCA;
        public const int GL_INT_SAMPLER_3D = 0x8DCB;
        public const int GL_INT_SAMPLER_CUBE = 0x8DCC;
        public const int GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
        public const int GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
        public const int GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
        public const int GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
        public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
        public const int GL_BUFFER_ACCESS_FLAGS = 0x911F;
        public const int GL_BUFFER_MAP_LENGTH = 0x9120;
        public const int GL_BUFFER_MAP_OFFSET = 0x9121;
        public const int GL_DEPTH_COMPONENT32F = 0x8CAC;
        public const int GL_DEPTH32F_STENCIL8 = 0x8CAD;
        public const int GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        public const int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
        public const int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
        public const int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
        public const int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
        public const int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
        public const int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
        public const int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
        public const int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
        public const int GL_FRAMEBUFFER_DEFAULT = 0x8218;
        public const int GL_FRAMEBUFFER_UNDEFINED = 0x8219;
        public const int GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
        public const int GL_DEPTH_STENCIL = 0x84F9;
        public const int GL_UNSIGNED_INT_24_8 = 0x84FA;
        public const int GL_DEPTH24_STENCIL8 = 0x88F0;
        public const int GL_UNSIGNED_NORMALIZED = 0x8C17;
        public const int GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
        public const int GL_READ_FRAMEBUFFER = 0x8CA8;
        public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
        public const int GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
        public const int GL_RENDERBUFFER_SAMPLES = 0x8CAB;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        public const int GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
        public const int GL_COLOR_ATTACHMENT1 = 0x8CE1;
        public const int GL_COLOR_ATTACHMENT2 = 0x8CE2;
        public const int GL_COLOR_ATTACHMENT3 = 0x8CE3;
        public const int GL_COLOR_ATTACHMENT4 = 0x8CE4;
        public const int GL_COLOR_ATTACHMENT5 = 0x8CE5;
        public const int GL_COLOR_ATTACHMENT6 = 0x8CE6;
        public const int GL_COLOR_ATTACHMENT7 = 0x8CE7;
        public const int GL_COLOR_ATTACHMENT8 = 0x8CE8;
        public const int GL_COLOR_ATTACHMENT9 = 0x8CE9;
        public const int GL_COLOR_ATTACHMENT10 = 0x8CEA;
        public const int GL_COLOR_ATTACHMENT11 = 0x8CEB;
        public const int GL_COLOR_ATTACHMENT12 = 0x8CEC;
        public const int GL_COLOR_ATTACHMENT13 = 0x8CED;
        public const int GL_COLOR_ATTACHMENT14 = 0x8CEE;
        public const int GL_COLOR_ATTACHMENT15 = 0x8CEF;
        public const int GL_COLOR_ATTACHMENT16 = 0x8CF0;
        public const int GL_COLOR_ATTACHMENT17 = 0x8CF1;
        public const int GL_COLOR_ATTACHMENT18 = 0x8CF2;
        public const int GL_COLOR_ATTACHMENT19 = 0x8CF3;
        public const int GL_COLOR_ATTACHMENT20 = 0x8CF4;
        public const int GL_COLOR_ATTACHMENT21 = 0x8CF5;
        public const int GL_COLOR_ATTACHMENT22 = 0x8CF6;
        public const int GL_COLOR_ATTACHMENT23 = 0x8CF7;
        public const int GL_COLOR_ATTACHMENT24 = 0x8CF8;
        public const int GL_COLOR_ATTACHMENT25 = 0x8CF9;
        public const int GL_COLOR_ATTACHMENT26 = 0x8CFA;
        public const int GL_COLOR_ATTACHMENT27 = 0x8CFB;
        public const int GL_COLOR_ATTACHMENT28 = 0x8CFC;
        public const int GL_COLOR_ATTACHMENT29 = 0x8CFD;
        public const int GL_COLOR_ATTACHMENT30 = 0x8CFE;
        public const int GL_COLOR_ATTACHMENT31 = 0x8CFF;
        public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        public const int GL_MAX_SAMPLES = 0x8D57;
        public const int GL_HALF_FLOAT = 0x140B;
        public const int GL_MAP_READ_BIT = 0x0001;
        public const int GL_MAP_WRITE_BIT = 0x0002;
        public const int GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
        public const int GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
        public const int GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
        public const int GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
        public const int GL_RG = 0x8227;
        public const int GL_RG_INTEGER = 0x8228;
        public const int GL_R8 = 0x8229;
        public const int GL_RG8 = 0x822B;
        public const int GL_R16F = 0x822D;
        public const int GL_R32F = 0x822E;
        public const int GL_RG16F = 0x822F;
        public const int GL_RG32F = 0x8230;
        public const int GL_R8I = 0x8231;
        public const int GL_R8UI = 0x8232;
        public const int GL_R16I = 0x8233;
        public const int GL_R16UI = 0x8234;
        public const int GL_R32I = 0x8235;
        public const int GL_R32UI = 0x8236;
        public const int GL_RG8I = 0x8237;
        public const int GL_RG8UI = 0x8238;
        public const int GL_RG16I = 0x8239;
        public const int GL_RG16UI = 0x823A;
        public const int GL_RG32I = 0x823B;
        public const int GL_RG32UI = 0x823C;
        public const int GL_VERTEX_ARRAY_BINDING = 0x85B5;
        public const int GL_R8_SNORM = 0x8F94;
        public const int GL_RG8_SNORM = 0x8F95;
        public const int GL_RGB8_SNORM = 0x8F96;
        public const int GL_RGBA8_SNORM = 0x8F97;
        public const int GL_SIGNED_NORMALIZED = 0x8F9C;
        public const int GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
        public const int GL_COPY_READ_BUFFER = 0x8F36;
        public const int GL_COPY_WRITE_BUFFER = 0x8F37;
        public const int GL_COPY_READ_BUFFER_BINDING = 0x8F36;
        public const int GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
        public const int GL_UNIFORM_BUFFER = 0x8A11;
        public const int GL_UNIFORM_BUFFER_BINDING = 0x8A28;
        public const int GL_UNIFORM_BUFFER_START = 0x8A29;
        public const int GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
        public const int GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        public const int GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        public const int GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        public const int GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        public const int GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        public const int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const int GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        public const int GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        public const int GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        public const int GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
        public const int GL_UNIFORM_TYPE = 0x8A37;
        public const int GL_UNIFORM_SIZE = 0x8A38;
        public const int GL_UNIFORM_NAME_LENGTH = 0x8A39;
        public const int GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
        public const int GL_UNIFORM_OFFSET = 0x8A3B;
        public const int GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
        public const int GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
        public const int GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
        public const int GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
        public const int GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
        public const int GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
        public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
        public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        public const int GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        public const int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const uint GL_INVALID_INDEX = 0xFFFFFFFFu;
        public const int GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
        public const int GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
        public const int GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
        public const int GL_OBJECT_TYPE = 0x9112;
        public const int GL_SYNC_CONDITION = 0x9113;
        public const int GL_SYNC_STATUS = 0x9114;
        public const int GL_SYNC_FLAGS = 0x9115;
        public const int GL_SYNC_FENCE = 0x9116;
        public const int GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
        public const int GL_UNSIGNALED = 0x9118;
        public const int GL_SIGNALED = 0x9119;
        public const int GL_ALREADY_SIGNALED = 0x911A;
        public const int GL_TIMEOUT_EXPIRED = 0x911B;
        public const int GL_CONDITION_SATISFIED = 0x911C;
        public const int GL_WAIT_FAILED = 0x911D;
        public const uint GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
        public const ulong GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFFUL;
        public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
        public const int GL_ANY_SAMPLES_PASSED = 0x8C2F;
        public const int GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
        public const int GL_SAMPLER_BINDING = 0x8919;
        public const int GL_RGB10_A2UI = 0x906F;
        public const int GL_TEXTURE_SWIZZLE_R = 0x8E42;
        public const int GL_TEXTURE_SWIZZLE_G = 0x8E43;
        public const int GL_TEXTURE_SWIZZLE_B = 0x8E44;
        public const int GL_TEXTURE_SWIZZLE_A = 0x8E45;
        public const int GL_GREEN = 0x1904;
        public const int GL_BLUE = 0x1905;
        public const int GL_INT_2_10_10_10_REV = 0x8D9F;
        public const int GL_TRANSFORM_FEEDBACK = 0x8E22;
        public const int GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        public const int GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
        public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;
        public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;
        public const int GL_COMPRESSED_R11_EAC = 0x9270;
        public const int GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
        public const int GL_COMPRESSED_RG11_EAC = 0x9272;
        public const int GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
        public const int GL_COMPRESSED_RGB8_ETC2 = 0x9274;
        public const int GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
        public const int GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
        public const int GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
        public const int GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
        public const int GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
        public const int GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        public const int GL_MAX_ELEMENT_INDEX = 0x8D6B;
        public const int GL_NUM_SAMPLE_COUNTS = 0x9380;
        public const int GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

        #endregion

        #region GLES 2.0 Functions

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glActiveTexture")]
        public static partial void GlActiveTexture(uint texture);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glAttachShader")]
        public static partial void GlAttachShader(uint program, uint shader);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindAttribLocation")]
        public static partial void GlBindAttribLocation(uint program, uint index, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindBuffer")]
        public static partial void GlBindBuffer(uint target, uint buffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindFramebuffer")]
        public static partial void GlBindFramebuffer(uint target, uint framebuffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindRenderbuffer")]
        public static partial void GlBindRenderbuffer(uint target, uint renderbuffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindTexture")]
        public static partial void GlBindTexture(uint target, uint texture);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBlendColor")]
        public static partial void GlBlendColor(float red, float green, float blue, float alpha);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBlendEquation")]
        public static partial void GlBlendEquation(uint mode);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBlendEquationSeparate")]
        public static partial void GlBlendEquationSeparate(uint modeRGB, uint modeAlpha);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBlendFunc")]
        public static partial void GlBlendFunc(uint sfactor, uint dfactor);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBlendFuncSeparate")]
        public static partial void GlBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBufferData")]
        public static partial void GlBufferData(uint target, nint size, void* data, uint usage);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBufferSubData")]
        public static partial void GlBufferSubData(uint target, nint offset, nint size, void* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCheckFramebufferStatus")]
        public static partial uint GlCheckFramebufferStatus(uint target);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClear")]
        public static partial void GlClear(uint mask);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClearColor")]
        public static partial void GlClearColor(float red, float green, float blue, float alpha);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClearDepthf")]
        public static partial void GlClearDepthf(float d);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClearStencil")]
        public static partial void GlClearStencil(int s);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glColorMask")]
        public static partial void GlColorMask(byte red, byte green, byte blue, byte alpha);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCompileShader")]
        public static partial void GlCompileShader(uint shader);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCompressedTexImage2D")]
        public static partial void GlCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCompressedTexSubImage2D")]
        public static partial void GlCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCopyTexImage2D")]
        public static partial void GlCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCopyTexSubImage2D")]
        public static partial void GlCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCreateProgram")]
        public static partial uint GlCreateProgram();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCreateShader")]
        public static partial uint GlCreateShader(uint type);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCullFace")]
        public static partial void GlCullFace(uint mode);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteBuffers")]
        public static partial void GlDeleteBuffers(int n, uint* buffers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteFramebuffers")]
        public static partial void GlDeleteFramebuffers(int n, uint* framebuffers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteProgram")]
        public static partial void GlDeleteProgram(uint program);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteRenderbuffers")]
        public static partial void GlDeleteRenderbuffers(int n, uint* renderbuffers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteShader")]
        public static partial void GlDeleteShader(uint shader);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteTextures")]
        public static partial void GlDeleteTextures(int n, uint* textures);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDepthFunc")]
        public static partial void GlDepthFunc(uint func);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDepthMask")]
        public static partial void GlDepthMask(byte flag);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDepthRangef")]
        public static partial void GlDepthRangef(float n, float f);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDetachShader")]
        public static partial void GlDetachShader(uint program, uint shader);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDisable")]
        public static partial void GlDisable(uint cap);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDisableVertexAttribArray")]
        public static partial void GlDisableVertexAttribArray(uint index);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDrawArrays")]
        public static partial void GlDrawArrays(uint mode, int first, int count);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDrawElements")]
        public static partial void GlDrawElements(uint mode, int count, uint type, void* indices);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glEnable")]
        public static partial void GlEnable(uint cap);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glEnableVertexAttribArray")]
        public static partial void GlEnableVertexAttribArray(uint index);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFinish")]
        public static partial void GlFinish();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFlush")]
        public static partial void GlFlush();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFramebufferRenderbuffer")]
        public static partial void GlFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFramebufferTexture2D")]
        public static partial void GlFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFrontFace")]
        public static partial void GlFrontFace(uint mode);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenBuffers")]
        public static partial void GlGenBuffers(int n, uint* buffers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenerateMipmap")]
        public static partial void GlGenerateMipmap(uint target);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenFramebuffers")]
        public static partial void GlGenFramebuffers(int n, uint* framebuffers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenRenderbuffers")]
        public static partial void GlGenRenderbuffers(int n, uint* renderbuffers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenTextures")]
        public static partial void GlGenTextures(int n, uint* textures);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetActiveAttrib")]
        public static partial void GlGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetActiveUniform")]
        public static partial void GlGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetAttachedShaders")]
        public static partial void GlGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetAttribLocation")]
        public static partial int GlGetAttribLocation(uint program, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetBooleanv")]
        public static partial void GlGetBooleanv(uint pname, byte* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetBufferParameteriv")]
        public static partial void GlGetBufferParameteriv(uint target, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetError")]
        public static partial uint GlGetError();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetFloatv")]
        public static partial void GlGetFloatv(uint pname, float* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetFramebufferAttachmentParameteriv")]
        public static partial void GlGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetIntegerv")]
        public static partial void GlGetIntegerv(uint pname, int* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetProgramiv")]
        public static partial void GlGetProgramiv(uint program, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetProgramInfoLog")]
        public static partial void GlGetProgramInfoLog(uint program, int bufSize, int* length, byte* infoLog);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetRenderbufferParameteriv")]
        public static partial void GlGetRenderbufferParameteriv(uint target, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetShaderiv")]
        public static partial void GlGetShaderiv(uint shader, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetShaderInfoLog")]
        public static partial void GlGetShaderInfoLog(uint shader, int bufSize, int* length, byte* infoLog);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetShaderPrecisionFormat")]
        public static partial void GlGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetShaderSource")]
        public static partial void GlGetShaderSource(uint shader, int bufSize, int* length, byte* source);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetString")]
        public static partial byte* GlGetString(uint name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetTexParameterfv")]
        public static partial void GlGetTexParameterfv(uint target, uint pname, float* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetTexParameteriv")]
        public static partial void GlGetTexParameteriv(uint target, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetUniformfv")]
        public static partial void GlGetUniformfv(uint program, int location, float* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetUniformiv")]
        public static partial void GlGetUniformiv(uint program, int location, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetUniformLocation")]
        public static partial int GlGetUniformLocation(uint program, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetVertexAttribfv")]
        public static partial void GlGetVertexAttribfv(uint index, uint pname, float* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetVertexAttribiv")]
        public static partial void GlGetVertexAttribiv(uint index, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetVertexAttribPointerv")]
        public static partial void GlGetVertexAttribPointerv(uint index, uint pname, void** pointer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glHint")]
        public static partial void GlHint(uint target, uint mode);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsBuffer")]
        public static partial byte GlIsBuffer(uint buffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsEnabled")]
        public static partial byte GlIsEnabled(uint cap);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsFramebuffer")]
        public static partial byte GlIsFramebuffer(uint framebuffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsProgram")]
        public static partial byte GlIsProgram(uint program);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsRenderbuffer")]
        public static partial byte GlIsRenderbuffer(uint renderbuffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsShader")]
        public static partial byte GlIsShader(uint shader);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsTexture")]
        public static partial byte GlIsTexture(uint texture);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glLineWidth")]
        public static partial void GlLineWidth(float width);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glLinkProgram")]
        public static partial void GlLinkProgram(uint program);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glPixelStorei")]
        public static partial void GlPixelStorei(uint pname, int param);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glPolygonOffset")]
        public static partial void GlPolygonOffset(float factor, float units);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glReadPixels")]
        public static partial void GlReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glReleaseShaderCompiler")]
        public static partial void GlReleaseShaderCompiler();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glRenderbufferStorage")]
        public static partial void GlRenderbufferStorage(uint target, uint internalformat, int width, int height);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glSampleCoverage")]
        public static partial void GlSampleCoverage(float value, byte invert);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glScissor")]
        public static partial void GlScissor(int x, int y, int width, int height);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glShaderBinary")]
        public static partial void GlShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glShaderSource")]
        public static partial void GlShaderSource(uint shader, int count, byte** str, int* length);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glStencilFunc")]
        public static partial void GlStencilFunc(uint func, int ref_, uint mask);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glStencilFuncSeparate")]
        public static partial void GlStencilFuncSeparate(uint face, uint func, int ref_, uint mask);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glStencilMask")]
        public static partial void GlStencilMask(uint mask);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glStencilMaskSeparate")]
        public static partial void GlStencilMaskSeparate(uint face, uint mask);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glStencilOp")]
        public static partial void GlStencilOp(uint fail, uint zfail, uint zpass);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glStencilOpSeparate")]
        public static partial void GlStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexImage2D")]
        public static partial void GlTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexParameterf")]
        public static partial void GlTexParameterf(uint target, uint pname, float param);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexParameterfv")]
        public static partial void GlTexParameterfv(uint target, uint pname, float* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexParameteri")]
        public static partial void GlTexParameteri(uint target, uint pname, int param);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexParameteriv")]
        public static partial void GlTexParameteriv(uint target, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexSubImage2D")]
        public static partial void GlTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform1f")]
        public static partial void GlUniform1f(int location, float v0);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform1fv")]
        public static partial void GlUniform1fv(int location, int count, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform1i")]
        public static partial void GlUniform1i(int location, int v0);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform1iv")]
        public static partial void GlUniform1iv(int location, int count, int* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform2f")]
        public static partial void GlUniform2f(int location, float v0, float v1);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform2fv")]
        public static partial void GlUniform2fv(int location, int count, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform2i")]
        public static partial void GlUniform2i(int location, int v0, int v1);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform2iv")]
        public static partial void GlUniform2iv(int location, int count, int* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform3f")]
        public static partial void GlUniform3f(int location, float v0, float v1, float v2);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform3fv")]
        public static partial void GlUniform3fv(int location, int count, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform3i")]
        public static partial void GlUniform3i(int location, int v0, int v1, int v2);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform3iv")]
        public static partial void GlUniform3iv(int location, int count, int* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform4f")]
        public static partial void GlUniform4f(int location, float v0, float v1, float v2, float v3);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform4fv")]
        public static partial void GlUniform4fv(int location, int count, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform4i")]
        public static partial void GlUniform4i(int location, int v0, int v1, int v2, int v3);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform4iv")]
        public static partial void GlUniform4iv(int location, int count, int* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix2fv")]
        public static partial void GlUniformMatrix2fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix3fv")]
        public static partial void GlUniformMatrix3fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix4fv")]
        public static partial void GlUniformMatrix4fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUseProgram")]
        public static partial void GlUseProgram(uint program);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glValidateProgram")]
        public static partial void GlValidateProgram(uint program);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib1f")]
        public static partial void GlVertexAttrib1f(uint index, float x);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib1fv")]
        public static partial void GlVertexAttrib1fv(uint index, float* v);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib2f")]
        public static partial void GlVertexAttrib2f(uint index, float x, float y);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib2fv")]
        public static partial void GlVertexAttrib2fv(uint index, float* v);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib3f")]
        public static partial void GlVertexAttrib3f(uint index, float x, float y, float z);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib3fv")]
        public static partial void GlVertexAttrib3fv(uint index, float* v);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib4f")]
        public static partial void GlVertexAttrib4f(uint index, float x, float y, float z, float w);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttrib4fv")]
        public static partial void GlVertexAttrib4fv(uint index, float* v);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttribPointer")]
        public static partial void GlVertexAttribPointer(uint index, int size, uint type, byte normalized, int stride, void* pointer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glViewport")]
        public static partial void GlViewport(int x, int y, int width, int height);

        #endregion

        #region GLES 3.0 Functions

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glReadBuffer")]
        public static partial void GlReadBuffer(uint src);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDrawRangeElements")]
        public static partial void GlDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexImage3D")]
        public static partial void GlTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexSubImage3D")]
        public static partial void GlTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCopyTexSubImage3D")]
        public static partial void GlCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCompressedTexImage3D")]
        public static partial void GlCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCompressedTexSubImage3D")]
        public static partial void GlCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenQueries")]
        public static partial void GlGenQueries(int n, uint* ids);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteQueries")]
        public static partial void GlDeleteQueries(int n, uint* ids);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsQuery")]
        public static partial byte GlIsQuery(uint id);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBeginQuery")]
        public static partial void GlBeginQuery(uint target, uint id);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glEndQuery")]
        public static partial void GlEndQuery(uint target);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetQueryiv")]
        public static partial void GlGetQueryiv(uint target, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetQueryObjectuiv")]
        public static partial void GlGetQueryObjectuiv(uint id, uint pname, uint* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUnmapBuffer")]
        public static partial byte GlUnmapBuffer(uint target);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetBufferPointerv")]
        public static partial void GlGetBufferPointerv(uint target, uint pname, void** @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDrawBuffers")]
        public static partial void GlDrawBuffers(int n, uint* bufs);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix2x3fv")]
        public static partial void GlUniformMatrix2x3fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix3x2fv")]
        public static partial void GlUniformMatrix3x2fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix2x4fv")]
        public static partial void GlUniformMatrix2x4fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix4x2fv")]
        public static partial void GlUniformMatrix4x2fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix3x4fv")]
        public static partial void GlUniformMatrix3x4fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformMatrix4x3fv")]
        public static partial void GlUniformMatrix4x3fv(int location, int count, byte transpose, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBlitFramebuffer")]
        public static partial void GlBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glRenderbufferStorageMultisample")]
        public static partial void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFramebufferTextureLayer")]
        public static partial void GlFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glMapBufferRange")]
        public static partial void* GlMapBufferRange(uint target, nint offset, nint length, uint access);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFlushMappedBufferRange")]
        public static partial void GlFlushMappedBufferRange(uint target, nint offset, nint length);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindVertexArray")]
        public static partial void GlBindVertexArray(uint array);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteVertexArrays")]
        public static partial void GlDeleteVertexArrays(int n, uint* arrays);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenVertexArrays")]
        public static partial void GlGenVertexArrays(int n, uint* arrays);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsVertexArray")]
        public static partial byte GlIsVertexArray(uint array);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetIntegeri_v")]
        public static partial void GlGetIntegeri_v(uint target, uint index, int* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBeginTransformFeedback")]
        public static partial void GlBeginTransformFeedback(uint primitiveMode);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glEndTransformFeedback")]
        public static partial void GlEndTransformFeedback();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindBufferRange")]
        public static partial void GlBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindBufferBase")]
        public static partial void GlBindBufferBase(uint target, uint index, uint buffer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTransformFeedbackVaryings")]
        public static partial void GlTransformFeedbackVaryings(uint program, int count, byte** varyings, uint bufferMode);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetTransformFeedbackVarying")]
        public static partial void GlGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttribIPointer")]
        public static partial void GlVertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetVertexAttribIiv")]
        public static partial void GlGetVertexAttribIiv(uint index, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetVertexAttribIuiv")]
        public static partial void GlGetVertexAttribIuiv(uint index, uint pname, uint* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttribI4i")]
        public static partial void GlVertexAttribI4i(uint index, int x, int y, int z, int w);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttribI4ui")]
        public static partial void GlVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttribI4iv")]
        public static partial void GlVertexAttribI4iv(uint index, int* v);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttribI4uiv")]
        public static partial void GlVertexAttribI4uiv(uint index, uint* v);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetUniformuiv")]
        public static partial void GlGetUniformuiv(uint program, int location, uint* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetFragDataLocation")]
        public static partial int GlGetFragDataLocation(uint program, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform1ui")]
        public static partial void GlUniform1ui(int location, uint v0);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform2ui")]
        public static partial void GlUniform2ui(int location, uint v0, uint v1);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform3ui")]
        public static partial void GlUniform3ui(int location, uint v0, uint v1, uint v2);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform4ui")]
        public static partial void GlUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform1uiv")]
        public static partial void GlUniform1uiv(int location, int count, uint* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform2uiv")]
        public static partial void GlUniform2uiv(int location, int count, uint* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform3uiv")]
        public static partial void GlUniform3uiv(int location, int count, uint* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniform4uiv")]
        public static partial void GlUniform4uiv(int location, int count, uint* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClearBufferiv")]
        public static partial void GlClearBufferiv(uint buffer, int drawbuffer, int* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClearBufferuiv")]
        public static partial void GlClearBufferuiv(uint buffer, int drawbuffer, uint* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClearBufferfv")]
        public static partial void GlClearBufferfv(uint buffer, int drawbuffer, float* value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClearBufferfi")]
        public static partial void GlClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetStringi")]
        public static partial byte* GlGetStringi(uint name, uint index);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glCopyBufferSubData")]
        public static partial void GlCopyBufferSubData(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetUniformIndices")]
        public static partial void GlGetUniformIndices(uint program, int uniformCount, byte** uniformNames, uint* uniformIndices);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetActiveUniformsiv")]
        public static partial void GlGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetUniformBlockIndex")]
        public static partial uint GlGetUniformBlockIndex(uint program, [MarshalAs(UnmanagedType.LPUTF8Str)] string uniformBlockName);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetActiveUniformBlockiv")]
        public static partial void GlGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetActiveUniformBlockName")]
        public static partial void GlGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glUniformBlockBinding")]
        public static partial void GlUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDrawArraysInstanced")]
        public static partial void GlDrawArraysInstanced(uint mode, int first, int count, int instancecount);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDrawElementsInstanced")]
        public static partial void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glFenceSync")]
        public static partial IntPtr GlFenceSync(uint condition, uint flags);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsSync")]
        public static partial byte GlIsSync(IntPtr sync);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteSync")]
        public static partial void GlDeleteSync(IntPtr sync);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glClientWaitSync")]
        public static partial uint GlClientWaitSync(IntPtr sync, uint flags, ulong timeout);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glWaitSync")]
        public static partial void GlWaitSync(IntPtr sync, uint flags, ulong timeout);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetInteger64v")]
        public static partial void GlGetInteger64v(uint pname, long* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetSynciv")]
        public static partial void GlGetSynciv(IntPtr sync, uint pname, int count, int* length, int* values);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetInteger64i_v")]
        public static partial void GlGetInteger64i_v(uint target, uint index, long* data);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetBufferParameteri64v")]
        public static partial void GlGetBufferParameteri64v(uint target, uint pname, long* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenSamplers")]
        public static partial void GlGenSamplers(int count, uint* samplers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteSamplers")]
        public static partial void GlDeleteSamplers(int count, uint* samplers);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsSampler")]
        public static partial byte GlIsSampler(uint sampler);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindSampler")]
        public static partial void GlBindSampler(uint unit, uint sampler);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glSamplerParameteri")]
        public static partial void GlSamplerParameteri(uint sampler, uint pname, int param);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glSamplerParameteriv")]
        public static partial void GlSamplerParameteriv(uint sampler, uint pname, int* param);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glSamplerParameterf")]
        public static partial void GlSamplerParameterf(uint sampler, uint pname, float param);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glSamplerParameterfv")]
        public static partial void GlSamplerParameterfv(uint sampler, uint pname, float* param);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetSamplerParameteriv")]
        public static partial void GlGetSamplerParameteriv(uint sampler, uint pname, int* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetSamplerParameterfv")]
        public static partial void GlGetSamplerParameterfv(uint sampler, uint pname, float* @params);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glVertexAttribDivisor")]
        public static partial void GlVertexAttribDivisor(uint index, uint divisor);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glBindTransformFeedback")]
        public static partial void GlBindTransformFeedback(uint target, uint id);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glDeleteTransformFeedbacks")]
        public static partial void GlDeleteTransformFeedbacks(int n, uint* ids);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGenTransformFeedbacks")]
        public static partial void GlGenTransformFeedbacks(int n, uint* ids);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glIsTransformFeedback")]
        public static partial byte GlIsTransformFeedback(uint id);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glPauseTransformFeedback")]
        public static partial void GlPauseTransformFeedback();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glResumeTransformFeedback")]
        public static partial void GlResumeTransformFeedback();

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetProgramBinary")]
        public static partial void GlGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glProgramBinary")]
        public static partial void GlProgramBinary(uint program, uint binaryFormat, void* binary, int length);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glProgramParameteri")]
        public static partial void GlProgramParameteri(uint program, uint pname, int value);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glInvalidateFramebuffer")]
        public static partial void GlInvalidateFramebuffer(uint target, int numAttachments, uint* attachments);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glInvalidateSubFramebuffer")]
        public static partial void GlInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexStorage2D")]
        public static partial void GlTexStorage2D(uint target, int levels, uint internalformat, int width, int height);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glTexStorage3D")]
        public static partial void GlTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);

        [LibraryImport(Lib, EntryPoint = EntryPointPrefix + "glGetInternalformativ")]
        public static partial void GlGetInternalformativ(uint target, uint internalformat, uint pname, int count, int* @params);

        #endregion
    }
}
