using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace _3DMapTool
{
    class Time
    {
        [DllImport("KERNEL32")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        #region Singleton
        private static Time instance = new Time();
        public static Time Instance
        {
            get { return instance; }
            private set { }
        }
        #endregion


        long frequency;                 // 주파수
        long currentTick = 0;           // 현재 측정시간
        long oldTick = 0;               // 이전 측정시간
        long elapsed = 0;               // 전 프레임 걸린시간(CPU Tick)
        static int frameCount = 0;      // 총 프레임 수
        float secCount = 0f;            // 초단위 갱신용
        static int fpsCount = 0;        // 초당 프레임 수 카운트
        static int fps = 0;             // 초당 프레임 수

        private static float deltaTime = 0f;
        public static float DeltaTime
        {
            get { return deltaTime; }
            private set { }
        }

        public static int FrameCount
        {
            get { return frameCount; }
            private set { }
        }
        public static int FPS
        {
            get { return fps; }
            private set { }
        }

        private Time()
        {
            if (QueryPerformanceFrequency(out frequency) == false)
            {
                // Frequency not supported
                throw new Win32Exception();
            }
        }
        public static void Update()
        {
            if(Instance.oldTick == 0)
            {
                QueryPerformanceCounter(out Instance.oldTick);
                return;
            }
            
            QueryPerformanceCounter(out Instance.currentTick);

            Instance.elapsed = Instance.currentTick - Instance.oldTick; // 걸린 시간 Tick
            deltaTime = (float)Instance.elapsed / Instance.frequency;
            Instance.secCount += deltaTime;
            instance.oldTick = instance.currentTick;
            frameCount++;
            fpsCount++;

            if(Instance.secCount >= 1.0f)
            {
                Instance.secCount = 0.0f;
                fps = fpsCount;
                fpsCount = 0;
            }

        }
    }
}
