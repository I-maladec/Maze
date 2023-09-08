using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Transform : Component
    {
        public Vector2int position;
        public override void Start()
        {
            
        }
        public override void Update()
        {
            Master.World.InsertGameObject(gameObject, position);
        }
        public Transform(Vector2int position)
        {
            this.position = position;
        }
    }
}
