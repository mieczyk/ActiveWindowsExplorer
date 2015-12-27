using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ActiveWindowsExplorer.Core.WinApi
{
    public delegate bool EnumWindowsCallback(IntPtr handler, IntPtr param);

    public static class WindowFunctions
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool EnumWindows(EnumWindowsCallback callback, IntPtr param);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr root, EnumWindowsCallback callback, IntPtr param);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool IsWindowVisible(IntPtr handler);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetAncestor(IntPtr handler, int flags);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr handler);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetLastActivePopup(IntPtr handler);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowText(IntPtr handler, StringBuilder title, int maxSize);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr handler, StringBuilder className, int maxSize);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTitleBarInfo(IntPtr hwnd, ref TITLEBARINFO pti);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
    }
}
