using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class ObjectManager
    {
        private static ObjectManager instance = new ObjectManager();
        
        public Dictionary<string, GameObject> objectList = new Dictionary<string, GameObject>();
        
        private ObjectManager()
        {
            
        }

        public static ObjectManager Instance
        {
            get { return instance; }
            private set { }
        }

        public static void Update()
        {
            foreach(var iter in instance.objectList)
            {
                iter.Value.Update();
            }
        }

        public static void Render()
        {
            foreach (var iter in instance.objectList)
            {
                iter.Value.Render();
            }
        }

        public static GameObject CreateObject(string key)
        {
            string objKey = key;

            if(objKey == string.Empty)
            {
                GameObject obj;
                string tag = "GameObject";
                int count = 1;
                string name;
                while(true)
                {
                    name = tag + count.ToString();
                    // 없는 키면 해당키로 오브젝트 생성
                    if (instance.objectList.TryGetValue(name, out obj) == false)
                    {
                        objKey = name;
                        break;
                    }
                    // 있는 키면 숫자 올려서 없는 키 일때까지
                    count++;

                }
                
            }
            GameObject go = new GameObject();
            go.name = objKey;
            instance.objectList.Add(objKey, go);

            return go;
        }

        public static void DeleteObject(string key) 
        {
            instance.objectList.Remove(key);
        }

        public static void AddObject(GameObject obj)
        {
            instance.objectList.Add(obj.name, obj);
        }
    }
}
