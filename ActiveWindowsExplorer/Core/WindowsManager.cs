using System;
using System.Collections.Generic;
using System.Linq;

namespace ActiveWindowsExplorer.Core
{
    public class WindowsManager
    {
        private readonly WindowsExplorer _explorer;

        public IEnumerable<WindowInfo> Windows { get; private set; }

        public IDictionary<WindowInfo, WindowInfo[]> WindowsWithDescendants
        {
            get
            {
                var windowsMap = new Dictionary<WindowInfo, WindowInfo[]>();

                var rootWindows = Windows.Where(w => w.RootHandler == IntPtr.Zero);
                foreach (var rootWindow in rootWindows)
                {
                    var descendants = Windows.Where(w => w.RootHandler == rootWindow.Handler);
                    windowsMap.Add(rootWindow, descendants.ToArray());
                }

                return windowsMap;
            }
        }

        public WindowsManager(WindowsExplorer explorer)
        {
            _explorer = explorer;
        }

        public void LoadActiveWindows()
        {
            var activeWindows = _explorer.GetAltTabWindows();
            var descendants = new List<WindowInfo>();
            
            foreach (var window in activeWindows)
            {
                descendants.AddRange(_explorer.GetDescendantWindows(window.Handler));    
            }

            Windows = activeWindows.Concat(descendants);
        }
    }
}
