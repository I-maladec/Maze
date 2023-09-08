using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Camera : Component
    {
        string line = "";
        GameObject[] gameObjects;
        public override void Start()
        {

        }
        public override void Update()
        {
            gameObjects = Master.World.GetWorld();
            for(int i = 0; i < Master.World.worldSize.y; i++)
            {
                for(int j = 0; j < Master.World.worldSize.x; j++)
                {
                    int a = i * Master.World.worldSize.x + j;
                    if (gameObjects[a] != null)
                    {
                        if (gameObjects[a].GetComponent<CharRenderer> != null)
                        {
                            line += gameObjects[a].GetComponent<CharRenderer>().skin;
                        }
                        else line += " ";
                    }
                    else line += " ";
                }
                Console.WriteLine(line);
                line = "";
            }
            Console.Clear();
        }
    }
}
