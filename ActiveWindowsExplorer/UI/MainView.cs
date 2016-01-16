using System;
using System.Windows.Forms;
using ActiveWindowsExplorer.Core;

namespace ActiveWindowsExplorer.UI
{
    public partial class MainView : Form, IMainView
    {
        private readonly WindowsManager _manager;

        public MainView()
        {
            InitializeComponent();
            _manager = new WindowsManager(new WindowsExplorer());
        }

        private void refresh_button_click(object sender, EventArgs e)
        {
            //_manager.LoadActiveWindows();

            //_windowsTreeView.Nodes.Clear();

            //var handlers = _manager.Windows.Select(w => w.Handler);
            //var rootWindows = _manager.Windows.Where(w => !handlers.Contains(w.ParentHandler));

            //foreach (var window in rootWindows)
            //{
            //    var rootNode = _windowsTreeView.Nodes.Add(window.Handler.ToString(), window.ToString());
            //    populate_tree_view_for_window(window, rootNode);
            //}

            //label1.Text = _manager.Windows.Count().ToString();
        }

        private void populate_tree_view_for_window(WindowInfo window, TreeNode node)
        {
            //var children = _manager.Windows.Where(w => w.ParentHandler == window.Handler);

            //foreach (var child in children)
            //{
            //    var childNode = node.Nodes.Add(child.Handler.ToString(), child.ToString());
            //    populate_tree_view_for_window(child, childNode);
            //}
        }
    }
}
