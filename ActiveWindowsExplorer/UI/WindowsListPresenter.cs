using System.Linq;
using ActiveWindowsExplorer.Core;

namespace ActiveWindowsExplorer.UI
{
    public class WindowsListPresenter
    {
        private readonly IWindowsListView _view;
        private readonly WindowsManager _manager;

        public WindowsListPresenter(IWindowsListView view, WindowsManager manager)
        {
            _view = view;
            _manager = manager;
        }

        public void Refresh()
        {
            _manager.LoadActiveWindows();
            _view.PopulateTreeView(_manager.Windows.ToList());
        }
    }
}
