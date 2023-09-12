using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace MazeGame
{
    internal class GameObject : Component
    {
        private List<Component> components = new List<Component>();
        public T GetComponent<T>() where T : Component
        {
            return components.OfType<T>().FirstOrDefault();
        }
        public List<Component> GetComponents()
        {
            return components;
        }
        public override void Start()
        {
            for(int i = 0; i < components.Count; i++)
            {
                components[i].gameObject = this;
            }
        }
        public override void Update()
        {

        }
        public GameObject AddComponent(Component component)
        {
            components.Add(component);
            return this;
        }
        public GameObject(string name, List<Component> components)
        {
            this.components = components;
            this.Name = name;
        }
        public GameObject(string name)
        {
            this.Name = name;
        }
    }
}
