using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _3DMapTool
{
    class GameObject
    {
        public Transform transform = null;
        private Dictionary<string, IComponent> components = new Dictionary<string, IComponent>();

        public string name = string.Empty;


        public GameObject()
        {
            transform = (Transform)AddComponent<Transform>("Transform");
        }


        public virtual void Update()
        {
            foreach(var iter in components)
            {
                CustomMesh mesh = iter.Value as CustomMesh;
                if (mesh != null) continue;
                iter.Value.Update();
            }
        }
        public virtual void Render()
        {
            foreach (var iter in components)
            {
                CustomMesh mesh = iter.Value as CustomMesh;
                if (mesh == null) continue;
                iter.Value.Update();
            }
        }

        public void AddComponent(string key, IComponent component)
        {
            component.gameObject = this;
            component.transform = this.transform;
            components.Add(key, component);
        }
        public IComponent AddComponent<T>(string key) where T : new()
        {
            T comp = new T();
            IComponent component = comp as IComponent;
            if(component == null)
            {
                MessageBox.Show("잘못된 컴포넌트 타입");
                return null;
            }
            component.gameObject = this;
            component.transform = this.transform;
            components.Add(key, component);

            return component;
        }

        public IComponent GetComponent(string key)
        {
            IComponent comp;
            if(components.TryGetValue(key,out comp))
            {
                return comp;
            }

            return null;
        }


    }
}
