using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace _3DMapTool
{
    class Camera : GameObject
    {
        public static Camera main
        {
            get
            {
                Camera mainCam = null;
                if(cams.TryGetValue("MainCamera",out mainCam))
                {
                    return mainCam;
                }
                return null;
            }
            private set { }
        }

        public static Dictionary<string, Camera> cams = new Dictionary<string, Camera>();
        public Vector3 look;
        public Vector3 up;
        public Device device = null;
        public float nearClipPlane = 1.0f;
        public float farClipPlane = 1000.0f;
        public Matrix viewMatrix;
        public Matrix projectionMatrix;
        public Camera()
        {
            transform.position.X = 0;
            transform.position.Y = 0;
            transform.position.Z = -3;
            look.X = 0;
            look.Y = 0;
            look.Z = 1;
            up.X = 0;
            up.Y = 1;
            up.Z = 0;

            device = RenderManager.Instance.device;
            

            // 뷰
            viewMatrix = Matrix.LookAtLH(transform.position, look, up);
            device.SetTransform(TransformType.View, viewMatrix);

            //투영
            projectionMatrix = Matrix.PerspectiveFovLH(
                (float)Math.PI * 0.5f,
                (float)device.Viewport.Width / device.Viewport.Height,
                nearClipPlane,
                farClipPlane);
            device.SetTransform(TransformType.Projection, projectionMatrix);
        
        
        
        
        
        }

        public override void Update()
        {
            base.Update();
            // 뷰
            viewMatrix = Matrix.LookAtLH(transform.position, look, up);
            device.SetTransform(TransformType.View, viewMatrix);

            //투영
            projectionMatrix = Matrix.PerspectiveFovLH(
                (float)Math.PI * 0.5f,
                (float)device.Viewport.Width / device.Viewport.Height,
                nearClipPlane,
                farClipPlane);
            device.SetTransform(TransformType.Projection, projectionMatrix);
        }

        public static Camera CreateCamera(string key)
        {
            Camera cam = new Camera();
            cam.name = key;
            cams.Add(key, cam);
            ObjectManager.AddObject(cam);
            return cam;
        }

        public static void DeleteCamera(string key)
        {
            ObjectManager.DeleteObject(key);
            cams.Remove(key);
        }

        public Ray ScreenPointToRay(Vector3 pos)
        {
            Ray ray;
            ray.origin = main.transform.position;

            Matrix viewProj = main.viewMatrix * main.projectionMatrix;

            
            // Screen To Projection
            Vector3 direction = new Vector3();
            direction.X = (pos.X * 2.0f / device.Viewport.Width) - 1.0f;
            direction.Y = -(pos.Y * 2.0f / device.Viewport.Height) + 1.0f;
            direction.Z = nearClipPlane;

            // Projection To World
            
            Matrix inverseMat = Matrix.Invert(viewProj);
            direction = Vector3.TransformCoordinate(direction, inverseMat);
            direction = direction - ray.origin;
            direction = Vector3.Normalize(direction);

            ray.direction = direction;


            return ray;
        }
    }
}
