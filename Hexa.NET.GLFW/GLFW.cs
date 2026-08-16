namespace Hexa.NET.GLFW
{
    using System.Runtime.InteropServices;

    public partial class GLFW
    {
        static GLFW() => InitApi();

        public static string GetLibraryName() => 
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "glfw3" : "libglfw";
    }
}