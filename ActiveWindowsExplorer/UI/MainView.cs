using System.Windows.Forms;
using ActiveWindowsExplorer.Core;

namespace ActiveWindowsExplorer.UI
{
    public interface IMainView
    {
    }

    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            
            var manager = new WindowsManager(new WindowsExplorer());
            
            _windowsListView.Initialize(new WindowsListPresenter(_windowsListView, manager));
        }
    }
}
