using System.Collections.Generic;
using System.Linq;

namespace ActiveWindowsExplorer.Core
{
    public class WindowsManager
    {
        private readonly WindowsExplorer _explorer;

        public IEnumerable<WindowInfo> Windows { get; private set; }

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
