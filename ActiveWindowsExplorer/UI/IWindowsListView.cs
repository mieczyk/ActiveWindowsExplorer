using System.Collections.Generic;
using ActiveWindowsExplorer.Core;

namespace ActiveWindowsExplorer.UI
{
    public interface IWindowsListView
    {
        void AttachPresenter(WindowsListPresenter presenter);
        void PopulateTreeView(IReadOnlyCollection<WindowInfo> windows);
    }
}
