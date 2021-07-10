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
        public Device device = null;
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
            pp.BackBufferWidth = 800;
            pp.BackBufferHeight = 600;
            pp.BackBufferFormat = Format.A8R8G8B8;
            pp.BackBufferCount = 1;

            pp.MultiSample = MultiSampleType.None;
            pp.MultiSampleQuality = 0;

            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            pp.EnableAutoDepthStencil = true;
            pp.AutoDepthStencilFormat = DepthFormat.D24S8;
            pp.FullScreenRefreshRateInHz = 0;
            pp.PresentationInterval = PresentInterval.Immediate;
            instance.device = new Device(0, DeviceType.Hardware, target, CreateFlags.SoftwareVertexProcessing | CreateFlags.MultiThreaded, pp);

            instance.sprite = new Sprite(instance.device);
            instance.line = new Line(instance.device);
        }

        public static void Clear()
        {
            instance.device.Clear(ClearFlags.Target | ClearFlags.ZBuffer | ClearFlags.Stencil, Color.Blue, 1.0f, 0);
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
