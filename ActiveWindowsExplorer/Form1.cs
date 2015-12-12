using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ActiveWindowsExplorer.Core.WinApi;

namespace ActiveWindowsExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refresh_button_click(object sender, EventArgs e)
        {
            WindowFunctions.EnumWindows((handler, param) =>
            {
                if (!is_alt_tab_window(handler))
                {
                    return true;
                }

                var title = get_window_title(handler);

                _windowsTreeView.Nodes.Add(title);
                label1.Text = _windowsTreeView.Nodes.Count.ToString();
                
                return true;
            }, IntPtr.Zero);
        }

        private bool is_alt_tab_window(IntPtr handler)
        {
            if (!WindowFunctions.IsWindowVisible(handler))
            {
                return false;
               }

            var handlerTry = IntPtr.Zero;
            var handlerWalk = IntPtr.Zero;

            handlerTry = WindowFunctions.GetAncestor(handler, Constants.GA_ROOTOWNER);
            while (handlerTry != handlerWalk)
            {
                handlerWalk = handlerTry;
                handlerTry = WindowFunctions.GetLastActivePopup(handlerWalk);

                if (WindowFunctions.IsWindowVisible(handlerTry))
                {
                    break;
                }
            }

            if (handlerWalk != handler)
            {
                return false;
            }

            // The following removes some task tray programs and "Program Manager".
            var tbi = new TITLEBARINFO();
            tbi.cbSize = Marshal.SizeOf(tbi);
            WindowFunctions.GetTitleBarInfo(handler,ref tbi);

            if ((tbi.rgstate[0] & Constants.STATE_SYSTEM_INVISIBLE) != 0)
            {
                return false;
            }

            // Tool windows should not be displayed either, these do not appear in the
            // task bar.
            if ((WindowFunctions.GetWindowLong(handler, Constants.GWL_EXSTYLE) & Constants.WS_EX_TOOLWINDOW) > 0)
            {
                return false;
            }

            return true;
        }

        private string get_window_title(IntPtr handler)
        {
            var title = new StringBuilder(1024);
            WindowFunctions.GetWindowText(handler, title, 1024);

            return title.ToString();
        }
    }
}
