using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Master
    {
        public static Master CycleMaster = new Master();
        public static World World = new World();
        private List<GameObject> gameObjects = new List<GameObject>();
        private List<Component> components = new List<Component>();
        static void Main()
        {
            Instantiate("camera", new List<Component> {new Camera()});
            Instantiate("player", new List<Component> { new Transform(new Vector2int(1, 1)), new CharRenderer('@') });
            MasterStart();
            while(true)
            {
                MasterUpdate();
            }
        }
        static void MasterUpdate()
        {
            for (int i = 0; i < CycleMaster.gameObjects.Count; i++)
            {
                CycleMaster.components = CycleMaster.gameObjects[i].GetComponents();
                for(int j = 0; j < CycleMaster.gameObjects[i].GetComponents().Count; j++)
                {
                    CycleMaster.components[j].Update();
                }
            }
            World.ClearWorld();
        }
        static void MasterStart()
        {
            for (int i = 0; i < CycleMaster.gameObjects.Count; i++)
            {
                CycleMaster.components = CycleMaster.gameObjects[i].GetComponents();
                for (int j = 0; j < CycleMaster.gameObjects[i].GetComponents().Count; j++)
                {
                    CycleMaster.components[j].Start();
                }
            }
        }
        static void Instantiate(string name, List<Component> components)
        {
            CycleMaster.gameObjects.Add(new GameObject(name, components));
        }
        static void Instantiate(string name)
        {
            CycleMaster.gameObjects.Add(new GameObject(name));
        }
    }
}
