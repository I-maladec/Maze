using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal abstract class Component
    {
        public string Name;
        public GameObject gameObject;
        public abstract void Start();
        public abstract void Update();
    }
}