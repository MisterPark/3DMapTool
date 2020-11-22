using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _3DMapTool
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    internal class WMListener : NativeWindow
    {
        // Constant value was found in the "windows.h" header file.
        private const int WM_ACTIVATEAPP = 0x001C;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_RBUTTONUP = 0x0205;
        private const int WM_LBUTTONDBLCLK = 0x0203;
        private const int WM_RBUTTONDBLCLK = 0x0206;
        private const int WM_MOUSEWHEEL = 0x020A;

        private Form1 parent;

        public WMListener(Form1 parent)
        {

            parent.HandleCreated += new EventHandler(this.OnHandleCreated);
            parent.HandleDestroyed += new EventHandler(this.OnHandleDestroyed);
            this.parent = parent;
        }

        // Listen for the control's window creation and then hook into it.
        internal void OnHandleCreated(object sender, EventArgs e)
        {
            // Window is now created, assign handle to NativeWindow.
            AssignHandle(((Form1)sender).Handle);
        }
        internal void OnHandleDestroyed(object sender, EventArgs e)
        {
            // Window was destroyed, release hook.
            ReleaseHandle();
        }
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            // Listen for operating system messages

            switch (m.Msg)
            {

                case WM_ACTIVATEAPP:

                    break;
                case WM_LBUTTONDOWN:
                    Input.Instance.mouse[(int)MouseInputType.LButtonDown] = true;
                    Input.Instance.mouse[(int)MouseInputType.LButton] = true;
                    break;
                case WM_RBUTTONDOWN:
                    Input.Instance.mouse[(int)MouseInputType.RButtonDown] = true;
                    Input.Instance.mouse[(int)MouseInputType.RButton] = true;
                    break;
                case WM_LBUTTONUP:
                    Input.Instance.mouse[(int)MouseInputType.LButtonUp] = true;
                    Input.Instance.mouse[(int)MouseInputType.LButton] = false;
                    break;
                case WM_RBUTTONUP:
                    Input.Instance.mouse[(int)MouseInputType.RButtonUp] = true;
                    Input.Instance.mouse[(int)MouseInputType.RButton] = false;
                    break;
                case WM_LBUTTONDBLCLK:
                    Input.Instance.mouse[(int)MouseInputType.LButtonDouble] = true;
                    break;
                case WM_RBUTTONDBLCLK:
                    Input.Instance.mouse[(int)MouseInputType.RButtonDouble] = true;
                    break;
                case WM_MOUSEWHEEL:
                    int wparam = m.WParam.ToInt32();
                    ushort hiword = (ushort)(wparam >> 16);
                    if (hiword > 0)
                    {
                        Input.Instance.mouse[(int)MouseInputType.WheelUp] = true;
                    }
                    else
                    {
                        Input.Instance.mouse[(int)MouseInputType.WheelDown] = true;
                    }


                    break;
            }


            base.WndProc(ref m);

        }
    }
}
