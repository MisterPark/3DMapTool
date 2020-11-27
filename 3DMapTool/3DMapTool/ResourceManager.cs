using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _3DMapTool
{
    class ResourceManager
    {
        private static ResourceManager instance = new ResourceManager();
        private Dictionary<string, StaticMesh> staticMeshMap = new Dictionary<string, StaticMesh>();

        private ResourceManager()
        {

        }

        public static ResourceManager Instance
        {
            get { return instance; }
            private set { }
        }

        public static bool LoadStaticMesh(string path, string fileName)
        {
            StaticMesh mesh = new StaticMesh();
            if (mesh.LoadMesh(path, fileName) == false) 
            {
                return false;
            }
            
            // 키생성
            string key = string.Empty;
            for (int i = 0; i < fileName.Length; i++) 
            {
                if (fileName[i] == '.') break;

                key += fileName[i];
            }

            instance.staticMeshMap.Add(key, mesh);
            return true;
        }

        public static StaticMesh CloneStaticMesh(string key)
        {

            StaticMesh mesh;
            if (instance.staticMeshMap.TryGetValue(key, out mesh) == false) 
            {
                MessageBox.Show("로드되지 않은 스태틱 매쉬 참조");
                return null;
            }

            return (StaticMesh)mesh.Clone();
        }


    }
}
