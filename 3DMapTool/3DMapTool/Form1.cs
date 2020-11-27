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
        GameObject selectedObject = null;

        //=======================================
        // 생성자
        //=======================================
        public Form1()
        {
            InitializeComponent();
            renderPanel.MouseWheel += RenderPanel_MouseWheel;
            wmListener = new WMListener(this);
            // 렌더 패널 지정
            g_renderPanel = renderPanel;
            // 디바이스 초기화
            RenderManager.InitializeDevice(renderPanel);

            // 리소스 로드
            LoadResources();

            Camera.CreateCamera("MainCamera");

            // 타이머 세팅
            timer.Interval = 20;
            timer.Tick += new EventHandler(Loop);
            timer.Start();
        }

        private void RenderPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            float delta = e.Delta / 120.0f;
            if(delta > 0) // UP
            {
                Camera.main.transform.position = Camera.main.transform.position + (delta * Camera.main.look * 5.0f);
            }
            else if(delta < 0) // DOWN
            {
                Camera.main.transform.position = Camera.main.transform.position + (delta * Camera.main.look * 5.0f) ;
            }
        }

        public void Loop(object sender, EventArgs e)
        {
            Input.Update();
            ObjectManager.Update();

            RenderManager.Clear();
            ObjectManager.Render();
            RenderManager.Present(g_renderPanel);

        }

        public void LoadResources()
        {
            
            
            TreeNode root = treeViewMesh.Nodes[0];
            TreeNode smeshNode = root.Nodes[0];
            TreeNode dmeshNode = root.Nodes[1];


            //\\Resources\\Mesh\\
            ResourceManager.LoadStaticMesh("", "malp.x");
            smeshNode.Nodes.Add("malp");

        }

        public void SetGameObjectInfo()
        {
            if (selectedObject == null) return;

            groupBoxInfo.Text = selectedObject.name;

            numericUpDown1.Value = (decimal)selectedObject.transform.position.X;
            numericUpDown2.Value = (decimal)selectedObject.transform.position.Y;
            numericUpDown3.Value = (decimal)selectedObject.transform.position.Z;
            numericUpDown4.Value = (decimal)selectedObject.transform.eulerAngles.X;
            numericUpDown5.Value = (decimal)selectedObject.transform.eulerAngles.Y;
            numericUpDown6.Value = (decimal)selectedObject.transform.eulerAngles.Z;
            numericUpDown7.Value = (decimal)selectedObject.transform.scale.X;
            numericUpDown8.Value = (decimal)selectedObject.transform.scale.Y;
            numericUpDown9.Value = (decimal)selectedObject.transform.scale.Z;
        }

        private void buttonMesh_Click(object sender, EventArgs e)
        {
            if (treeViewMesh.SelectedNode.Name == "nodeMesh") return;
            if (treeViewMesh.SelectedNode.Name == "nodeStaticMesh") return;
            if (treeViewMesh.SelectedNode.Name == "nodeDynamicMesh") return;

            string key = treeViewMesh.SelectedNode.Text;

            StaticMesh mesh = ResourceManager.CloneStaticMesh(key);
            if (mesh == null) return;

            GameObject obj = ObjectManager.CreateObject("");
            obj.AddComponent("Mesh", mesh);

            treeViewObject.Nodes[0].Nodes.Add(obj.name);
        }

        private void treeViewObject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeViewObject.Nodes[0] == e.Node) return;

            string key = e.Node.Text;
            GameObject obj;
            if(ObjectManager.Instance.objectList.TryGetValue(key, out obj))
            {
                selectedObject = obj;

                SetGameObjectInfo();
            }
            
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            selectedObject.transform.position.X = (float)numericUpDown1.Value;
            selectedObject.transform.position.Y = (float)numericUpDown2.Value;
            selectedObject.transform.position.Z = (float)numericUpDown3.Value;
            selectedObject.transform.eulerAngles.X = (float)numericUpDown4.Value;
            selectedObject.transform.eulerAngles.Y = (float)numericUpDown5.Value;
            selectedObject.transform.eulerAngles.Z = (float)numericUpDown6.Value;
            selectedObject.transform.scale.X = (float)numericUpDown7.Value;
            selectedObject.transform.scale.Y = (float)numericUpDown8.Value;
            selectedObject.transform.scale.Z = (float)numericUpDown9.Value;
        }
    }
}
