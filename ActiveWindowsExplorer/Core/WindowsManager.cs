using System.Collections.Generic;

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
            Windows = _explorer.GetAltTabWindows();
        }
    }
}
