using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class World
    {
        public Vector2int worldSize = new Vector2int(50, 50); // временное решение
        private GameObject[] gameObjects = new GameObject[2500];
        public void InsertGameObject(GameObject gameObject, Vector2int position)
        { 
            gameObjects[position.y*worldSize.x+position.x] = gameObject;
        }
        public GameObject GetGameObject(Vector2int position)
        {
            int a = position.y * worldSize.x + position.x;
            if (gameObjects[position.y * worldSize.x + position.x] != null)
            {
                return gameObjects[position.y * worldSize.x + position.x];
            }
            else return null;
        }
        public void ClearWorld()
        {

            gameObjects = new GameObject[2500];
        }
        public GameObject[] GetWorld()
        {
            return gameObjects;
        }
    }
}
