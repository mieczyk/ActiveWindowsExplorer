using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ActiveWindowsExplorer.Core.WinApi;

namespace ActiveWindowsExplorer.Core
{
    public class WindowsExplorer
    {
        public IList<WindowInfo> GetAltTabWindows()
        {
            var windows = new List<WindowInfo>();

            WindowFunctions.EnumWindows((handler, param) =>
            {
                if (is_alt_tab_window(handler))
                {
                    var window = new WindowInfo(handler);
                    
                    load_children_windows_for(window);

                    windows.Add(window);
                }

                return true;
            }, IntPtr.Zero);

            return windows;
        }

        private static bool is_alt_tab_window(IntPtr handler)
        {
            if (!WindowFunctions.IsWindowVisible(handler))
            {
                return false;
            }

            var handlerWalk = IntPtr.Zero;
            var handlerTry = WindowFunctions.GetAncestor(handler, Constants.GA_ROOTOWNER);

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
            WindowFunctions.GetTitleBarInfo(handler, ref tbi);

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

        private static void load_children_windows_for(WindowInfo window)
        {
            
        }
    }
}
