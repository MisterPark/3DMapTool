using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class MeshCollider : Collider
    {
        public MeshCollider()
        {
        }

        public MeshCollider(MeshCollider rhs) : base(rhs)
        {
        }

        public MeshCollider(ref GameObject owner) : base(ref owner)
        {
        }
        

        public override IComponent Clone()
        {
            return new MeshCollider(this);
        }

        public override bool Raycast(Ray ray, out RaycastHit outHitInfo, float maxDistance)
        {
            RaycastHit info;
            info.distance = 0;
            info.collider = null;
            info.point = new Vector3(0, 0, 0);
            outHitInfo = info;

            CustomMesh sharedMesh = null;
            StaticMesh smesh = (StaticMesh)gameObject.GetComponent<StaticMesh>();
            if(smesh != null)
            {
                sharedMesh = smesh;
            }
            if (sharedMesh == null) return false;

            Vector3[] vertexPositions = null;
            int[] indices = null;
            // 버텍스 버퍼 가져오기
            // 인덱스 버퍼 가져오기
            vertexPositions = sharedMesh.GetVertices();
            if (vertexPositions == null) return false;
            int vertexCount = sharedMesh.GetVertexCount();
            indices = sharedMesh.GetIndices();
            if (indices == null) return false;
            int triangleCount = sharedMesh.GetFaceCount();
            // 

            // TODO : (약함)로컬에서 충돌검사를 해야 빠르겠지...?
            Matrix matWorld = transform.world;
            
            int index, ind;
            Vector3 v1;
            Vector3 v2;
            Vector3 v3;
            for (int i = 0; i < triangleCount; i++)
            {
                index = i * 3;
                ind = indices[index];
                v1 = vertexPositions[indices[index]];
                v2 = vertexPositions[indices[index + 1]];
                v3 = vertexPositions[indices[index + 2]];

                v1 = Vector3.TransformCoordinate(v1, matWorld);
                v2 = Vector3.TransformCoordinate(v2, matWorld);
                v3 = Vector3.TransformCoordinate(v3, matWorld);

                IntersectInformation intersectInfo;
                if(Geometry.IntersectTri(v1,v2,v3,ray.origin,ray.direction, out intersectInfo))
                {
                    info.distance = intersectInfo.Dist;
                    info.collider = this;
                    info.point = v1 + intersectInfo.U * (v2 - v1) + intersectInfo.V * (v3 - v1);
                    outHitInfo = info;

                    return true;
                }

            }


            return false;

            
        }
    }
}
