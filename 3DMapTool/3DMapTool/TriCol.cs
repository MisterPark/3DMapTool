using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3DMapTool
{
    class TriCol : CustomMesh
    {
        Device device;
        Mesh mesh;
        int vertexCount = 0;
        int vertexSize = 0;
        int faceCount = 0;
        Vector3[] vertices;
        int[] indices;


        public TriCol()
        {
            device = RenderManager.Instance.device;

            faceCount = 1;
            vertexCount = 3;
            short[] indices = { 0, 1, 2 };

            mesh = new Mesh(faceCount, vertexCount, MeshFlags.Managed,
                     CustomVertex.PositionColored.Format, device);
            this.vertices = new Vector3[vertexCount];
            this.indices = new int[faceCount * 3];

            using (VertexBuffer vb = mesh.VertexBuffer)
            {
                GraphicsStream data = vb.Lock(0, 0, LockFlags.None);

                Vector3 a = new Vector3(-1.0f, 0.0f, -1.0f);
                Vector3 b = new Vector3(0.0f, 0.0f, 1.0f);
                Vector3 c = new Vector3(1.0f, 0.0f, -1.0f);

                data.Write(new CustomVertex.PositionColored(a, 0x00ff0000));
                data.Write(new CustomVertex.PositionColored(b, 0x00ff0000));
                data.Write(new CustomVertex.PositionColored(c, 0x00ff0000));

                this.vertices[0] = a;
                this.vertices[1] = b;
                this.vertices[2] = c;

                vb.Unlock();
            }

            using (IndexBuffer ib = mesh.IndexBuffer)
            {
                ib.SetData(indices, 0, LockFlags.None);
            }

            int indexCount = faceCount * 3;
            for(int i=0;i<indexCount;i++)
            {
                this.indices[i] = indices[i];
            }


        }

        public TriCol(TriCol rhs) : base(rhs)
        {
            this.device = rhs.device;
            this.mesh = rhs.mesh;
            this.vertexCount = rhs.vertexCount;
            this.vertexSize = rhs.vertexSize;
            this.faceCount = rhs.faceCount;
            this.vertices = new Vector3[vertexCount];
            this.indices = new int[faceCount * 3];

            for (int i = 0; i < vertexCount; i++) 
            {
                this.vertices[i] = rhs.vertices[i];
            }

            int indexCount = faceCount * 3;
            for (int i = 0; i < indexCount; i++) 
            {
                this.indices[i] = rhs.indices[i];
            }
        }

        public TriCol(ref GameObject owner) : base(ref owner)
        {
            
        }

        public override IComponent Clone()
        {
            return new TriCol(this);
        }

        public override int GetFaceCount()
        {
            return faceCount;
        }

        public override int[] GetIndices()
        {
            return indices;
        }

        public override int GetVertexCount()
        {
            return vertexCount;
        }

        public override int GetVertexSize()
        {
            return vertexSize;
        }

        public override Vector3[] GetVertices()
        {
            return vertices;
        }

        public override void Update()
        {
            if (gameObject == null) return;
            if (transform == null) return;

            var device = RenderManager.Instance.device;
            device.SetTransform(TransformType.World, transform.world);
            device.SetRenderState(RenderStates.ShadeMode, (int)ShadeMode.Flat);
            
            device.SetRenderState(RenderStates.Lighting, false);
            device.SetRenderState(RenderStates.CullMode, (int)Cull.CounterClockwise);

            device.SetTexture(0, null);
            mesh.DrawSubset(0);

            device.SetRenderState(RenderStates.CullMode, (int)Cull.CounterClockwise);
            device.SetRenderState(RenderStates.Lighting, true);
            device.SetRenderState(RenderStates.AlphaBlendEnable, false);
            device.SetRenderState(RenderStates.AlphaTestEnable, false);
            device.SetTexture(0, null);
        }

        public void SetVertexPos(Vector3 a, Vector3 b, Vector3 c)
        {
            using (VertexBuffer vb = mesh.VertexBuffer)
            {
                GraphicsStream data = vb.Lock(0, 0, LockFlags.None);

                data.Write(new CustomVertex.PositionColored(a, 0x00ff0000));
                data.Write(new CustomVertex.PositionColored(b, 0x00ff0000));
                data.Write(new CustomVertex.PositionColored(c, 0x00ff0000));

                this.vertices[0] = a;
                this.vertices[1] = b;
                this.vertices[2] = c;

                vb.Unlock();
            }
        }
    }
}
