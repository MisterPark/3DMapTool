using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.IO;

namespace _3DMapTool
{
    struct NavIndex
    {
        public int a, b, c;
    }
    class NavManager : GameObject
    {
        

        private static NavManager instance = new NavManager();
        private Dictionary<int, Vector3> vertices = new Dictionary<int, Vector3>();
        private List<NavIndex> indices = new List<NavIndex>();
        private int vertexCount = 0;
        private List<TriCol> cells = new List<TriCol>();

        private NavManager()
        {

        }

        public static NavManager Instance
        {
            get { return instance; }
            private set { }
        }

        public override void Update()
        {
            foreach(TriCol cell in instance.cells)
            {
                cell.Update();
            }
        }

        public static void AddVertex(Vector3 pos)
        {
            instance.vertexCount++;
            instance.vertices.Add(instance.vertexCount, pos);

            GameObject obj = ObjectManager.CreateObject("Vertex");
            obj.transform.position = pos;
            obj.AddComponent<SphereCollider>("SphereCollider");
            Form1.g_vertexList.Items.Add(obj.name);

            if (instance.vertexCount %3 == 0)
            {
                NavIndex index;
                index.a = instance.vertexCount - 2;
                index.b = instance.vertexCount - 1;
                index.c = instance.vertexCount;
                instance.indices.Add(index);
                TriCol tri = new TriCol();
                tri.SetVertexPos(instance.vertices[index.a], instance.vertices[index.b], instance.vertices[index.c]);
                tri.gameObject = instance;
                tri.transform = instance.transform;
                instance.cells.Add(tri);
            }
        }

        public static void RemoveVertex(int index)
        {
            instance.vertices.Remove(index);

            foreach(NavIndex navIdx in instance.indices)
            {
                if(navIdx.a == index)
                {
                    instance.vertices.Remove(index+1);
                    instance.vertices.Remove(index+2);
                    instance.indices.Remove(navIdx);
                }
                else if (navIdx.b == index)
                {
                    instance.vertices.Remove(index-1);
                    instance.vertices.Remove(index+1);
                    instance.indices.Remove(navIdx);
                }
                else if(navIdx.c == index)
                {
                    instance.vertices.Remove(index-2);
                    instance.vertices.Remove(index-1);
                    instance.indices.Remove(navIdx);
                }
            }
        }

        public static void Save()
        {
            FileStream fs = File.Create("nav.dat");
            fs.Close();


            BinaryWriter sw = new BinaryWriter(new FileStream("nav.dat",FileMode.Open,FileAccess.Write));

            sw.Write(instance.vertices.Count);

            foreach(var iter in instance.vertices)
            {
                Vector3 vertex = iter.Value;
                sw.Write(vertex.X);
                sw.Write(vertex.Y);
                sw.Write(vertex.Z);
            }

            sw.Close();
            
        }

        public static void Load()
        {
            BinaryReader sr = new BinaryReader(new FileStream("nav.dat", FileMode.Open, FileAccess.Read));
            int vertexCnt = sr.ReadInt32();

            for (int i = 0; i < vertexCnt; i++) 
            {
                float x = sr.ReadSingle();
                float y = sr.ReadSingle();
                float z = sr.ReadSingle();

                AddVertex(new Vector3(x, y, z));
            }

            sr.Close();
        }

    }
}
