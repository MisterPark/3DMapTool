using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class Transform
    {
        public Vector3 scale;
        public Vector3 rotation;
        public Vector3 position;
        public Matrix world;

        public Transform()
        {
            position.X = 0;
            position.Y = 0;
            position.Z = 0;
            rotation.X = 0;
            rotation.Y = 0;
            rotation.Z = 0;
            scale.X = 1;
            scale.Y = 1;
            scale.Z = 1;
            world = Matrix.Identity;
        }
    }
}
