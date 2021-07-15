using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class StaticMesh : CustomMesh
    {
        Mesh originMesh = null;
        public Mesh mesh = null;

        GraphicsStream adjacency;
        Material[] materials;
        Texture[] textures;

        int subsetCount = 0;

        // 공용정보
        int vertexSize = 0;
        int vertexCount = 0;
        int faceCount = 0;
        Vector3[] vertices;
        int[] indices;

        public StaticMesh()
        {
        }

        public StaticMesh(StaticMesh rhs) : base(rhs)
        {
            this.originMesh = rhs.originMesh;
            this.mesh = rhs.mesh;
            this.adjacency = rhs.adjacency;
            this.materials = rhs.materials;
            this.textures = rhs.textures;
            this.subsetCount = rhs.subsetCount;
            this.vertices = rhs.vertices;
            this.indices = rhs.indices;
            this.vertexSize = rhs.vertexSize;
            this.vertexCount = rhs.vertexCount;
            this.faceCount = rhs.faceCount;
        }

        public StaticMesh(ref GameObject owner) : base(ref owner)
        {
        }

        ~StaticMesh()
        {
            originMesh.Dispose();
            mesh.Dispose();

        }

        public override IComponent Clone()
        {
            return new StaticMesh(this);
        }

        public override void Update()
        {
            if (gameObject == null) return;
            if (transform == null) return;

            var device = RenderManager.Instance.device;
            device.SetTransform(TransformType.World, transform.world);

            device.SetRenderState(RenderStates.AlphaBlendEnable, true);
            //device.SetRenderState(RenderStates.SourceBlend, (int)Blend.SourceAlpha);
            //device.SetRenderState(RenderStates.DestinationBlend, (int)Blend.InvSourceAlpha);
            device.SetRenderState(RenderStates.AlphaTestEnable, true);
            device.SetRenderState(RenderStates.ReferenceAlpha, 0x00000088);
            device.SetRenderState(RenderStates.AlphaFunction, (int)Compare.Greater);
            device.SetRenderState(RenderStates.Lighting, false);
            device.SetRenderState(RenderStates.CullMode, (int)Cull.CounterClockwise);
            
            for (int i = 0; i < subsetCount; i++) 
            {
                device.Material = materials[i];
                device.SetTexture(0, textures[i]);
                mesh.DrawSubset(i);
                //device.DrawIndexedPrimitives(PrimitiveType.TriangleList,0,)
            }

            device.SetRenderState(RenderStates.CullMode, (int)Cull.CounterClockwise);
            device.SetRenderState(RenderStates.Lighting, true);
            device.SetRenderState(RenderStates.AlphaBlendEnable, false);
            device.SetRenderState(RenderStates.AlphaTestEnable, false);
            device.SetTexture(0,null);
        }

        public bool LoadMesh(string path, string fileName)
        {
            string fullPath = path + fileName;

            var device = RenderManager.Instance.device;

            ExtendedMaterial[] mats;
            originMesh = Mesh.FromFile(fullPath, MeshFlags.Managed, device, out adjacency, out mats);
            if(originMesh == null)
            {
                return false;
            }

            if((originMesh.VertexFormat & VertexFormats.Normal) == 0)
            {
                mesh = originMesh.Clone(originMesh.Options.Value, originMesh.VertexFormat | VertexFormats.Normal, device);
                mesh.ComputeNormals();
            }
            else
            {
                mesh = originMesh.Clone(originMesh.Options.Value, originMesh.VertexFormat, device);

            }
            

            materials = new Material[mats.Length];
            textures = new Texture[mats.Length];
            for (int i = 0; i < mats.Length; i++) 
            {
                materials[i] = mats[i].Material3D;
                materials[i].Ambient = materials[i].Diffuse;
                textures[i] = TextureLoader.FromFile(device,path+ mats[i].TextureFilename);
            }

            subsetCount = materials.Length;

            // 정보세팅
            vertexCount = mesh.NumberVertices;
            vertexSize = mesh.NumberBytesPerVertex;
            vertices = new Vector3[vertexCount];
            CustomVertex.PositionNormalTextured[] data = (CustomVertex.PositionNormalTextured[])mesh.VertexBuffer.Lock(0, typeof(CustomVertex.PositionNormalTextured), LockFlags.None, mesh.NumberVertices);
            
            for (int i = 0; i < vertexCount; i++) 
            {
                vertices[i] = data[i].Position;
            }
            mesh.VertexBuffer.Unlock();

            
            faceCount = mesh.NumberFaces;
            int indexCount = faceCount * 3;
            indices = new int[indexCount];
            bool is16Bit = mesh.IndexBuffer.Description.Is16BitIndices;
            if (is16Bit)
            {
                ushort[] indexbuff = (ushort[])mesh.IndexBuffer.Lock(0, typeof(ushort), LockFlags.None, indexCount);

                for (int i = 0; i < indexCount; i++)
                {
                    indices[i] = indexbuff[i];
                }
                mesh.IndexBuffer.Unlock();
            }
            else
            {
                int[] indexbuff = (int[])mesh.IndexBuffer.Lock(0, typeof(int), LockFlags.None, indexCount);

                for (int i = 0; i < indexCount; i++)
                {
                    indices[i] = indexbuff[i];
                }
                mesh.IndexBuffer.Unlock();
            }
            
            

            return true;
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

        public override int[] GetIndices()
        {
            return indices;
        }

        public override int GetFaceCount()
        {
            return faceCount;
        }
    }
}
