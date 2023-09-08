using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class CharRenderer : Component
    {
        public char skin;
        public override void Start()
        {

        }
        public override void Update()
        {

        }
        public CharRenderer(char skin)
        {
            this.skin = skin;
        }
    }
}