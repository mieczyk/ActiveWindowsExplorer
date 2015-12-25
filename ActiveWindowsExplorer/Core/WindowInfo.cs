﻿using System;
using System.Text;
using ActiveWindowsExplorer.Core.WinApi;

namespace ActiveWindowsExplorer.Core
{
    public class WindowInfo
    {
        public IntPtr RootHandler { get; private set; }
        public IntPtr Handler { get; private set; }
        public string Title { get; private set; }
        public string ClassName { get; private set; }

        public WindowInfo(IntPtr handler, IntPtr rootHandler)
        {
            Handler = handler;
            RootHandler = rootHandler;

            Title = extract_window_title(handler);
            ClassName = extract_window_class_name(handler);
        }

        private static string extract_window_title(IntPtr handler)
        {
            var title = new StringBuilder(1024);
            WindowFunctions.GetWindowText(handler, title, 1024);

            return title.ToString();
        }

        private static string extract_window_class_name(IntPtr handler)
        {
            var className = new StringBuilder(1024);
            WindowFunctions.GetClassName(handler, className, 1024);

            return className.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", Handler, Title, ClassName);
        }
    }
}
