using System;
using System.Collections.Generic;
using System.Text;


namespace _3DMapTool
{
    abstract class IComponent
    {
        public GameObject gameObject = null;
        public Transform transform = null;
        //==========================
        public IComponent()
        {

        }
        public IComponent(IComponent rhs)
        {

        }
        ~IComponent()
        {

        }
        public IComponent(ref GameObject owner)
        {
            this.gameObject = owner;
            this.transform = owner.transform;
        }

        

        public abstract void Update();
        public abstract IComponent Clone();


    }
}
