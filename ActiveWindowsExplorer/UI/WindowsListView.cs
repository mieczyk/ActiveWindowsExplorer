using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ActiveWindowsExplorer.Core;

namespace ActiveWindowsExplorer.UI
{
    public partial class WindowsListView : UserControl, IWindowsListView
    {
        private WindowsListPresenter _presenter;

        public WindowsListView()
        {
            InitializeComponent();
        }

        public void AttachPresenter(WindowsListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void PopulateTreeView(IReadOnlyCollection<WindowInfo> windows)
        {
            _windowsTreeView.Nodes.Clear();

            var handlers = windows.Select(w => w.Handler);
            var rootWindows = windows.Where(w => !handlers.Contains(w.ParentHandler));

            foreach (var window in rootWindows)
            {
                var rootNode = _windowsTreeView.Nodes.Add(window.Handler.ToString(), window.ToString());
                populate_tree_view_for_window(window, rootNode, windows);
            }

            _countLabel.Text = windows.Count().ToString();
        }

        private static void populate_tree_view_for_window(WindowInfo window, TreeNode node, IReadOnlyCollection<WindowInfo> windows)
        {
            var children = windows.Where(w => w.ParentHandler == window.Handler);

            foreach (var child in children)
            {
                var childNode = node.Nodes.Add(child.Handler.ToString(), child.ToString());
                populate_tree_view_for_window(child, childNode, windows);
            }
        }

        private void _refreshButton_Click(object sender, EventArgs e)
        {
            if (_presenter == null)
            {
                throw new InvalidOperationException("Presenter is not attached!");
            }

            _presenter.Refresh();
        }
    }
}
