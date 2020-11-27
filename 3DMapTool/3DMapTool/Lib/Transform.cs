using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class Transform : IComponent
    {
        public Vector3 scale;
        public Vector3 eulerAngles;
        public Quaternion rotation;
        public Vector3 position;
        public Matrix world;

        public Transform()
        {
            position.X = 0;
            position.Y = 0;
            position.Z = 0;
            eulerAngles.X = 0;
            eulerAngles.Y = 0;
            eulerAngles.Z = 0;
            rotation = Quaternion.Identity;
            scale.X = 1;
            scale.Y = 1;
            scale.Z = 1;
            world = Matrix.Identity;
        }

        public Transform(IComponent rhs) : base(rhs)
        {
        }

        public Transform(ref GameObject owner) : base(ref owner)
        {
        }

        public override IComponent Clone()
        {
            return new Transform(this);
        }

        public override void Update()
        {
            Matrix matScale = Matrix.Scaling(scale);
            Matrix matRot = Matrix.RotationQuaternion(rotation);
            Matrix matTrans = Matrix.Translation(position);

            world = matScale * matRot * matTrans;
        }
    }
}
