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

        public Vector3 right;
        public Vector3 up;
        public Vector3 look;

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

            right.X = 1;
            right.Y = 0;
            right.Z = 0;

            up.X = 0;
            up.Y = 1;
            up.Z = 0;

            look.X = 0;
            look.Y = 0;
            look.Z = 1;
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
            world = Matrix.Identity;

            eulerAngles.X = eulerAngles.X % 360;
            eulerAngles.Y = eulerAngles.Y % 360;
            eulerAngles.Z = eulerAngles.Z % 360;

            rotation = Quaternion.RotationYawPitchRoll(Mathf.ToRadian(eulerAngles.Y), Mathf.ToRadian(eulerAngles.X), Mathf.ToRadian(eulerAngles.Z));
            rotation = Quaternion.Normalize(rotation);

            Matrix matScale = Matrix.Scaling(scale);
            Matrix matRot = Matrix.RotationQuaternion(rotation);
            Matrix matTrans = Matrix.Translation(position);

            world = matScale * matRot * matTrans;


            right = new Vector3(1, 0, 0);
            up = new Vector3(0, 1, 0);
            look = new Vector3(0, 0, 1);

            right =Vector3.TransformNormal(right, matRot);
            up = Vector3.TransformNormal(up, matRot);
            look = Vector3.TransformNormal(look, matRot);

            right = Vector3.Normalize(right);
            up = Vector3.Normalize(up);
            look = Vector3.Normalize(look);
        }
    }
}
