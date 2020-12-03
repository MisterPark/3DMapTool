using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

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
        public static ListBox g_vertexList = null;
        GameObject selectedObject = null;
        // 카메라 공전용
        bool isWheelDown = false;
        Vector3 downPos;
        //모드
        Mode mode = Mode.Object;

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
            g_vertexList = listBoxVertex;
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
            float speed = Math.Abs(delta) * 5.0f;
            Vector3 direction = Camera.main.look - Camera.main.transform.position;
            direction = Vector3.Normalize(direction);
            if(delta > 0) // UP
            {
                Camera.main.transform.position += direction * speed;
            }
            else if(delta < 0) // DOWN
            {
                Camera.main.transform.position -= direction * speed;
            }
        }

        public void Loop(object sender, EventArgs e)
        {
            Input.Update();
            ObjectManager.Update();

            RenderManager.Clear();
            ObjectManager.Render();
            NavManager.Instance.Update();
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
            ResourceManager.LoadStaticMesh("Resources/Mesh/summoner_rift/", "summoner_rift.x");
            smeshNode.Nodes.Add("summoner_rift");
            ResourceManager.LoadStaticMesh("Resources/Mesh/", "testPlaneMesh.x");
            smeshNode.Nodes.Add("testPlaneMesh");

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
            obj.AddComponent<MeshCollider>("MeshCollider");
            

            SphereCollider sphere = new SphereCollider();
            if(sphere != null)
            {
                sphere.gameObject = obj;
                sphere.transform = obj.transform;
                obj.AddComponent("SphereCollider", sphere);
            }
            

            treeViewObject.Nodes[0].Nodes.Add(obj.name);
            treeViewObject.ExpandAll();
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
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            selectedObject.transform.position.Y = (float)numericUpDown2.Value;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            selectedObject.transform.position.Z = (float)numericUpDown3.Value;
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            float val = (float)numericUpDown4.Value % 360.0f;
            numericUpDown4.Value = (decimal)val;
            selectedObject.transform.eulerAngles.X = val;
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            float val = (float)numericUpDown5.Value % 360.0f;
            numericUpDown5.Value = (decimal)val;
            selectedObject.transform.eulerAngles.Y = val;
        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            float val = (float)numericUpDown6.Value % 360.0f;
            numericUpDown6.Value = (decimal)val;
            selectedObject.transform.eulerAngles.Z = val;
        }
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            selectedObject.transform.scale.X = (float)numericUpDown7.Value;
        }
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            selectedObject.transform.scale.Y = (float)numericUpDown8.Value;
        }
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (selectedObject == null) return;

            selectedObject.transform.scale.Z = (float)numericUpDown9.Value;
        }

        private void renderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Middle)
            {
                isWheelDown = true;
                downPos.X = e.Location.X;
                downPos.Y = e.Location.Y;
            }
            else if(e.Button == MouseButtons.Left)
            {
                this.ActiveControl = renderPanel;

                switch (mode)
                {
                    case Mode.Object:
                        {
                            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                foreach(TreeNode node in treeViewObject.Nodes[0].Nodes)
                                {
                                    if(node.Text == hit.collider.gameObject.name)
                                    {
                                        treeViewObject.SelectedNode = node;
                                        selectedObject = hit.collider.gameObject;
                                        SetGameObjectInfo();
                                    }
                                }
                            }
                        }
                        break;
                    case Mode.NavMesh:
                        {
                            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                
                                NavManager.AddVertex(hit.point);
                                
                            }
                        }
                        break;
                    default:
                        break;
                }
                // TODO : 여기부터
                
            }
            else //Right
            {

            }
        }

        private void renderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isWheelDown = false;
            }
        }

        private void renderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Input.mousePosition = new Vector3(e.Location.X, e.Location.Y, 0);

            if(isWheelDown)
            {

                int dx = e.Location.X - (int)downPos.X;
                int dy = -(e.Location.Y - (int)downPos.Y);
                downPos.X = e.Location.X;
                downPos.Y = e.Location.Y;

                Vector3 camLocalPos = Camera.main.transform.position - Camera.main.look;

                Vector3 camRight = Vector3.Cross(new Vector3(0, 1, 0), Camera.main.look);
                camRight = Vector3.Normalize(camRight);
                Vector3 camLook = Vector3.Normalize(Camera.main.look);
                Vector3 camUp = Vector3.Cross(camLook, camRight);
                camUp = Vector3.Normalize(camUp);

                float angleY = Mathf.ToRadian(dx);
                float angleX = Mathf.ToRadian(-dy);

                Matrix rot;
                Matrix rotY = Matrix.RotationAxis(camUp, angleY);
                Matrix rotX = Matrix.RotationAxis(camRight, angleX);
                
                rot = rotX * rotY;

                camLocalPos = Vector3.TransformCoordinate(camLocalPos, rot);
                //camLocalPos = Vector3.TransformCoordinate(camLocalPos, rotX);
                camLocalPos += Camera.main.look;

                Camera.main.transform.position = camLocalPos;
            }
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxMode.SelectedIndex;
            mode = (Mode)index;

            switch (mode)
            {
                case Mode.Object:

                    break;
                case Mode.NavMesh:
                    modeTabControl.SelectedIndex = 4;
                    break;
                default:
                    break;
            }
        }

        private void buttonSaveVertex_Click(object sender, EventArgs e)
        {
            NavManager.Save();
            MessageBox.Show("네비메쉬 저장");
        }

        private void buttonLoadVertex_Click(object sender, EventArgs e)
        {
            NavManager.Load();
            MessageBox.Show("네비메쉬 불러오기");
            
            
            
        }
    }
}
