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
            foreach (var windowInfo in _manager.Windows)
            {
                _windowsTreeView.Nodes.Add(windowInfo.Title);
            }

            label1.Text = _manager.Windows.Count().ToString();
        }
    }
}
