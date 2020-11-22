using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class RenderManager
    {
        private static RenderManager instance = new RenderManager();
        private Device device = null;
        private Sprite sprite = null;
        private Line line = null;
        private RenderManager()
        {

        }

        public static RenderManager Instance
        {
            get{ return instance; }
            private set { }
        }

        public static void InitializeDevice(Control target)
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            //pp.EnableAutoDepthStencil = true;
            //pp.AutoDepthStencilFormat = DepthFormat.D16;
            instance.device = new Device(0, DeviceType.Hardware, target, CreateFlags.HardwareVertexProcessing, pp);

            instance.sprite = new Sprite(instance.device);
            instance.line = new Line(instance.device);
        }

        public static void Clear()
        {
            instance.device.Clear(ClearFlags.Target, Color.Blue, 0.0f, 0);
            instance.device.BeginScene();
        }
        public static void Present(Control target)
        {
            instance.device.EndScene();
            instance.device.Present(target);
        }

        public static void Present(Control target, int width, int height)
        {
            instance.device.EndScene();
            instance.device.Present(new Rectangle(0, 0, width, height), target, false);
        }


    }
}
