using System.Windows.Forms;

namespace ActiveWindowsExplorer.UI
{
    public interface IWindowDetailsView
    {
    }

    public partial class WindowDetailsView : UserControl, IWindowDetailsView
    {
        public WindowDetailsView()
        {
            InitializeComponent();
        }
    }
}
