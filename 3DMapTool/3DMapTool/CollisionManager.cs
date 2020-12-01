using System;
using System.Collections.Generic;
using System.Text;

namespace _3DMapTool
{
    class CollisionManager
    {
        private static CollisionManager instance = new CollisionManager();
        public List<Collider> colliders = new List<Collider>();

        private CollisionManager()
        {

        }

        public static CollisionManager Instance
        {
            get { return instance; }
            private set { }
        }

        public static void Update()
        {
            foreach(Collider src in instance.colliders)
            {
                foreach (Collider dest in instance.colliders)
                {
                    if (src == dest) continue;

                    if(IsCollided(src,dest))
                    {

                    }
                }
            }
        }

        public static bool IsCollided(Collider src, Collider dest)
        {
            return false;
        }

        public static void Register(Collider collider)
        {
            foreach(Collider iter in instance.colliders)
            {
                if (iter == collider) return;
            }

            instance.colliders.Add(collider);
        }

        public static void Disregister(Collider collider)
        {
            instance.colliders.Remove(collider);
        }




    }
}
