using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3DMapTool
{
    public partial class Form1 : Form
    {
        //=======================================
        // 멤버
        //=======================================
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        WMListener wmListener;

        public static Panel g_renderPanel = null;

        //=======================================
        // 생성자
        //=======================================
        public Form1()
        {
            InitializeComponent();
            wmListener = new WMListener(this);
            // 렌더 타겟 지정
            g_renderPanel = renderPanel;
            // 디바이스 초기화
            RenderManager.InitializeDevice(renderPanel);

            timer.Interval = 20;
            timer.Tick += new EventHandler(Loop);
            timer.Start();
        }

        public void Loop(object sender, EventArgs e)
        {
            Input.Update();
            ObjectManager.Update();

            RenderManager.Clear();
            ObjectManager.Render();
            RenderManager.Present(g_renderPanel);

        }

    }
}
