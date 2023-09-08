using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class World
    {
        public Vector2int worldSize = new Vector2int(10, 10); // временное решение
        private GameObject[] gameObjects = new GameObject[100];
        public void InsertGameObject(GameObject gameObject, Vector2int position)
        { 
            gameObjects[position.y*worldSize.x+position.x] = gameObject;
        }
        public void ClearWorld()
        {

            gameObjects = new GameObject[100];
        }
        public GameObject[] GetWorld()
        {
            return gameObjects;
        }
    }
}
