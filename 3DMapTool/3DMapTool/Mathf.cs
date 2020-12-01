using System;
using System.Collections.Generic;
using System.Text;

namespace _3DMapTool
{
    class Mathf
    {
        public const float PI = (float)Math.PI;
        public static float ToRadian(float degree)
        {
            return (degree * Mathf.PI / 180.0f);
        }

        public static float ToDegree(float radian)
        {
            return (radian * 180.0f / Mathf.PI);
        }
    }
}
