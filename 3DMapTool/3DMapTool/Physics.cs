using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    struct Ray
    {
        public Vector3 origin;
        public Vector3 direction;

        public Vector3 GetPoint(float distance)
        {
            Vector3 result = origin + (direction * distance);
            return result;
        }
    }

    struct RaycastHit
    {
        public float distance;
        public Vector3 point;
        public Collider collider;
    }


    class Physics
    {
        public static bool Raycast(Ray ray, RaycastHit outHit, float maxDistance = float.PositiveInfinity)
        {
            foreach(Collider collider in CollisionManager.Instance.colliders)
            {
                if(collider.Raycast(ray, out outHit, maxDistance))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity)
        {
            Ray ray;
            ray.origin = origin;
            ray.direction = direction;
            RaycastHit hit;

            foreach (Collider collider in CollisionManager.Instance.colliders)
            {
                if (collider.Raycast(ray, out hit, maxDistance))
                {
                    return true;
                }
            }
            return false;
        }
    
    }
}
