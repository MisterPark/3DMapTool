using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _3DMapTool
{
    enum MouseInputType
    {
        LButton,
        RButton,
        LButtonUp,
        RButtonUp,
        LButtonDown,
        RButtonDown,
        LButtonDouble,
        RButtonDouble,
        WheelUp,
        WheelDown,

        End
    }

    class Input
    {
        [DllImport("user32")]
        public static extern UInt16 GetAsyncKeyState(Int32 vKey);

        public const uint RANGE_OF_KEYS = 256;
        public const uint INPUT_LIFE_FRAME = 2;
        private bool[] keys = new bool[RANGE_OF_KEYS];
        private bool[] keyDowns = new bool[RANGE_OF_KEYS];
        private bool[] keyUps = new bool[RANGE_OF_KEYS];

        private int[] mouseFrameCount = new int[(int)MouseInputType.End];
        public bool[] mouse = new bool[(int)MouseInputType.End];

        private static Input instance = new Input();
        private Input()
        {
            
        }

        public static Input Instance
        {
            get { return instance; }
            private set { }
        }

        public static void Update()
        {
            Clear();

            for (int i = 0; i < RANGE_OF_KEYS; i++)
            {
                ushort keystate = GetAsyncKeyState(i);
                instance.keys[i] = ((keystate & 0x8001) == 0) ? false : true;
                instance.keyDowns[i] = ((keystate & 0x0001) == 0) ? false : true;
                instance.keyUps[i] = ((keystate & 0x8000) == 0) ? false : true;
            }
        }

        public static void Clear()
        {
            Array.Clear(instance.keys, 0, instance.keys.Length);
            Array.Clear(instance.keyDowns, 0, instance.keyDowns.Length);
            Array.Clear(instance.keyUps, 0, instance.keyUps.Length);

            ClearMouseState();
        }

        public static void ClearMouseState()
        {
            int count = (int)MouseInputType.End;
            for (int i = 2; i < count; i++) 
            {
                if(instance.mouse[i])
                {
                    instance.mouseFrameCount[i]++;
                    if (instance.mouseFrameCount[i] == INPUT_LIFE_FRAME)
                    {
                        instance.mouseFrameCount[i] = 0;
                        instance.mouse[i] = false;
                    }
                }
            }
        }

        public static bool GetKey(Keys keyCode)
        {
            return instance.keys[(int)keyCode];
        }
        public static bool GetKeyUp(Keys keyCode)
        {
            return instance.keyUps[(int)keyCode];
        }
        public static bool GetKeyDown(Keys keyCode)
        {
            return instance.keyDowns[(int)keyCode];
        }

        public static bool GetMouseButton(MouseInputType keyCode)
        {
            return instance.mouse[(int)keyCode];
        }

    }
}
