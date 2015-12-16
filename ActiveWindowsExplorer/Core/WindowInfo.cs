using System;
using System.Collections.Generic;
using System.Text;
using ActiveWindowsExplorer.Core.WinApi;

namespace ActiveWindowsExplorer.Core
{
    public class WindowInfo
    {
        public IntPtr Handler { get; private set; }
        public string Title { get; private set; }

        public IList<WindowInfo> Children { get; private set; }

        public WindowInfo(IntPtr handler)
        {
            Handler = handler;

            Title = extract_window_title(handler);

            Children = new List<WindowInfo>();
        }

        private static string extract_window_title(IntPtr handler)
        {
            var title = new StringBuilder(1024);
            WindowFunctions.GetWindowText(handler, title, 1024);

            return title.ToString();
        }
    }
}
