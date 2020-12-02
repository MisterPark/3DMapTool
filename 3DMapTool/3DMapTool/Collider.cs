using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    enum ColliderType { None,Box,Sphere};
    abstract class Collider : IComponent
    {
        public Mesh mesh = null;
        protected List<Vector3> vertices = null;
        

        public Vector3 center;
        ColliderType type = ColliderType.None;

        public Collider()
        {
            CollisionManager.Register(this);
        }

        public Collider(Collider rhs) : base(rhs)
        {
            this.center = rhs.center;
            CollisionManager.Register(this);
        }

        public Collider(ref GameObject owner) : base(ref owner)
        {
            
        }

        ~Collider()
        {
            CollisionManager.Disregister(this);
        }

        public void SetColor(ColorValue color)
        {
            if (mesh == null) return;

            VertexElement[] decl = mesh.Declaration;
            short offset = 0;
            foreach(VertexElement elem in decl)
            {
                if(elem.DeclarationUsage == DeclarationUsage.Color)
                {
                    offset = elem.Offset;
                    break;
                }
            }

            // 작성
        }


        public override void Update()
        {
            
        }

        public void Render()
        {
            if (gameObject == null) return;
            if (transform == null) return;
            if (mesh == null) return;

            var device = RenderManager.Instance.device;

            device.SetTransform(TransformType.World, transform.world);
            device.SetRenderState(RenderStates.FillMode, (int)FillMode.WireFrame);
            device.SetRenderState(RenderStates.ShadeMode, (int)ShadeMode.Flat);
            device.SetRenderState(RenderStates.Lighting, false);

            mesh.DrawSubset(0);

            device.SetRenderState(RenderStates.Lighting, true);
            device.SetRenderState(RenderStates.FillMode, (int)FillMode.Solid);
        }

        public void OnCollisionEnter(Collider other)
        {
            if (gameObject == null) return;

            gameObject.OnCollisionEnter(other);
        }

        public abstract bool Raycast(Ray ray, out RaycastHit outHitInfo, float maxDistance);
    }
}
