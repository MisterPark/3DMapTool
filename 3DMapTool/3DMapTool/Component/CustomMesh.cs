using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    abstract class CustomMesh : IComponent
    {
        public CustomMesh()
        {

        }
        public CustomMesh(CustomMesh rhs) : base(rhs)
        {

        }
        public CustomMesh(ref GameObject owner) : base(ref owner)
        {
        }
        ~CustomMesh()
        {

        }

        public abstract int GetVertexCount();
        public abstract int GetVertexSize();
        public abstract Vector3[] GetVertices();
        public abstract int[] GetIndices();
        public abstract int GetFaceCount();
        
    }
}
