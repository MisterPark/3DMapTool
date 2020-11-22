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

        }

        public static void Render()
        {

        }
    }
}
