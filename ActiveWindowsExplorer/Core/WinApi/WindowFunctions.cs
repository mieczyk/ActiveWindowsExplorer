using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ActiveWindowsExplorer.Core.WinApi
{
    public delegate bool EnumWindowsCallback(IntPtr handler, IntPtr param);

    public static class WindowFunctions
    {
        [DllImport("User32.dll")]
        public static extern bool EnumWindows(EnumWindowsCallback callback, IntPtr param);

        [DllImport("User32.dll")]
        public static extern bool IsWindowVisible(IntPtr handler);

        [DllImport("User32.dll")]
        public static extern IntPtr GetAncestor(IntPtr handler, int flags);

        [DllImport("User32.dll")]
        public static extern IntPtr GetLastActivePopup(IntPtr handler);

        [DllImport("User32.dll")]
        public static extern int GetWindowText(IntPtr handler, StringBuilder title, int maxSize);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTitleBarInfo(IntPtr hwnd, ref TITLEBARINFO pti);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
    }
}
