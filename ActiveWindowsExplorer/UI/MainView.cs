using System.Windows.Forms;
using ActiveWindowsExplorer.Core;

namespace ActiveWindowsExplorer.UI
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            
            var manager = new WindowsManager(new WindowsExplorer());
            
            _windowsListView.AttachPresenter(new WindowsListPresenter(_windowsListView, manager));
        }
    }
}
