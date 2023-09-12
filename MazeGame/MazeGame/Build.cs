using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    static class Build
    {
        public static void BuildFrame(Vector2int position, Vector2int size, GameObject gameObjectSample)
        {
            for(int i = 0; i<size.x; i++)
            {
                for(int j = 0; j<size.y; j++)
                {
                    if(position.x == i || position.y == j || size.x-1 == i || size.y-1 == j)
                    {
                        Master.Instantiate(gameObjectSample.AddComponent(new Transform(new Vector2int(i,j))));
                    }
                }
            }
        }
    }
}
