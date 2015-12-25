using System;
using System.Linq;
using System.Windows.Forms;
using ActiveWindowsExplorer.Core;

namespace ActiveWindowsExplorer
{
    public partial class Form1 : Form
    {
        private readonly WindowsManager _manager;

        public Form1()
        {
            InitializeComponent();
            _manager = new WindowsManager(new WindowsExplorer());
        }

        private void refresh_button_click(object sender, EventArgs e)
        {
            _manager.LoadActiveWindows();

            _windowsTreeView.Nodes.Clear();

            var windowsWithDescendants = _manager.WindowsWithDescendants;

            foreach (var windowEntry in windowsWithDescendants)
            {
                var rootWindow = windowEntry.Key;
                var rootNode = _windowsTreeView.Nodes.Add(rootWindow.Handler.ToString(), rootWindow.ToString());

                foreach (var descendant in windowEntry.Value)
                {
                    rootNode.Nodes.Add(descendant.Handler.ToString(), descendant.ToString());
                }
            }

            label1.Text = _manager.Windows.Count().ToString();
        }
    }
}
