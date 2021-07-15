using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3DMapTool
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 form = new Form1();
            form.Show();
            
            while(form.Created)
            {
                Time.Update();
                form.Text = "박경훈 맵툴 - FPS : " + Time.FPS.ToString();
                Input.Update();
                ObjectManager.Update();
                RenderManager.Clear();
                ObjectManager.Render();
                NavManager.Instance.Update();
                RenderManager.Present(form.RenderPanel);
                Application.DoEvents();
            }
        }
    }
}
