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
            }

            device.SetRenderState(RenderStates.CullMode, (int)Cull.CounterClockwise);
            device.SetRenderState(RenderStates.Lighting, true);
            device.SetRenderState(RenderStates.AlphaBlendEnable, false);
            device.SetRenderState(RenderStates.AlphaTestEnable, false);
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
            for(int i=0;i< mats.Length;i++)
            {
                materials[i] = mats[i].Material3D;
                materials[i].Ambient = materials[i].Diffuse;
                textures[i] = TextureLoader.FromFile(device,path+ mats[i].TextureFilename);
            }

            subsetCount = materials.Length;

            return true;
        }
    }
}
