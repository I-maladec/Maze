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
        public void Translate(Vector2int transition)
        {
            if(Master.World.GetGameObject(new Vector2int(position.x += transition.x, position.y += transition.y))!=null)
            {
                if(Master.World.GetGameObject(new Vector2int(position.x += transition.x, position.y += transition.y)).GetComponent<Solid>()==null)
                {
                    position.x += transition.x;
                    position.y += transition.y;
                }
            }
            if(position.x < 0)
                position.x = 0;
            if (position.y < 0)
                position.y = 0;
        }
    }
}
