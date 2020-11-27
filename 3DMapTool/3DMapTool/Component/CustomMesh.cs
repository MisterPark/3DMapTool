using System;
using System.Collections.Generic;
using System.Text;

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
        
    }
}
