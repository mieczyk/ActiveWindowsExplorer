using System.Runtime.InteropServices;

namespace ActiveWindowsExplorer.Core.WinApi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TITLEBARINFO
    {
        public const int CCHILDREN_TITLEBAR = 5;
        public int cbSize;
        public RECT rcTitleBar;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = CCHILDREN_TITLEBAR + 1)]
        public uint[] rgstate;
    }
}
