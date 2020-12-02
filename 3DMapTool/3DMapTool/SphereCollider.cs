using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class SphereCollider : Collider
    {
        public float radius = 0.5f;
        public SphereCollider()
        {
            var device = RenderManager.Instance.device;

            Mesh smesh = Mesh.Sphere(device, radius, 16, 16);

            if ((smesh.VertexFormat & VertexFormats.Diffuse) == 0)
            {
                mesh = smesh.Clone(smesh.Options.Value, smesh.VertexFormat | VertexFormats.Diffuse, device);
            }
            else
            {
                mesh = smesh.Clone(smesh.Options.Value, smesh.VertexFormat, device);
            }
            
            // 컬러 오프셋 찾기
            VertexElement[] decl = mesh.Declaration;
            short offset = 0;
            foreach (VertexElement elem in decl)
            {
                if (elem.DeclarationUsage == DeclarationUsage.Color)
                {
                    offset = elem.Offset;
                    break;
                }
            }

            // 컬러값 접근

            ColorValue color = ColorValue.FromColor(Color.FromArgb(255, 0, 255, 0));
            CustomVertex.PositionNormalColored[] data = (CustomVertex.PositionNormalColored[])mesh.VertexBuffer.Lock(0, typeof(CustomVertex.PositionNormalColored), LockFlags.None, mesh.NumberVertices);
            for (int i = 0; i < mesh.NumberVertices; i++)
            {
                data[i].Color = color.ToArgb();
            }
            mesh.VertexBuffer.Unlock();

        }

        public SphereCollider(Collider rhs) : base(rhs)
        {
        }

        public SphereCollider(ref GameObject owner) : base(ref owner)
        {
        }

        public override IComponent Clone()
        {
            return new SphereCollider(this);
        }


        public override bool Raycast(Ray ray, out RaycastHit outHitInfo, float maxDistance)
        {
            RaycastHit info;
            info.distance = 0;
            info.collider = null;
            info.point = new Vector3(0, 0, 0);
            outHitInfo = info;

            if (transform == null)
            {
                return false;
            }

            Vector3 worldCenter = transform.position + center;
            Vector3 v = ray.origin - worldCenter;

            float b = 2.0f * Vector3.Dot(ray.direction, v);
            float c = Vector3.Dot(v, v) - (radius * radius);

            // 판별식
            float discriminant = (b * b) - (4.0f * c);
            // 가상의 수 테스트
            if (discriminant < 0.0f)
                return false;

            discriminant = (float)Math.Sqrt((double)discriminant);

            float t0 = (-b + discriminant) * 0.5f;
            float t1 = (-b - discriminant) * 0.5f;

            // 해가 >= 0 일 경우 교차
            if (t0 >= 0.0f || t1 >= 0.0f)
            {
                float nearT = Math.Min(Math.Abs(t0), Math.Abs(t1));
                // 광선(t) = 광선위치(p0) + t * 광선방향(u) 
                // p(t) = p0 + tu
                outHitInfo.point = ray.origin + nearT * ray.direction;
                outHitInfo.distance = Vector3.Length(ray.origin - outHitInfo.point);
                outHitInfo.collider = this;

                return true;
            }


            return false;
        }
    }
}
