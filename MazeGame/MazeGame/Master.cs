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
        public static InputManager InputManager = new InputManager();
        private static Camera camera;
        private List<GameObject> gameObjects = new List<GameObject>();
        private List<Component> components = new List<Component>();
        static void Main()
        {
            camera = Instantiate("camera", new List<Component> {new Camera()}).GetComponent<Camera>();
            Instantiate("player", new List<Component> { new Transform(new Vector2int(1, 1)), new CharRenderer('@'), new PlayerControl() });
            MasterStart();
            while(true)
            {
                InputManager.Input();
                MasterUpdate();
                camera.Render();
            }
        }
        static void MasterUpdate()
        {
            World.ClearWorld();
            for (int i = 0; i < CycleMaster.gameObjects.Count; i++)
            {
                CycleMaster.components = CycleMaster.gameObjects[i].GetComponents();
                for(int j = 0; j < CycleMaster.gameObjects[i].GetComponents().Count; j++)
                {
                    CycleMaster.components[j].Update();
                }
                CycleMaster.gameObjects[i].Update();
            }
        }
        static void MasterStart()
        {
            for (int i = 0; i < CycleMaster.gameObjects.Count; i++)
            {
                CycleMaster.gameObjects[i].Start();
                CycleMaster.components = CycleMaster.gameObjects[i].GetComponents();
                for (int j = 0; j < CycleMaster.gameObjects[i].GetComponents().Count; j++)
                {
                    CycleMaster.components[j].Start();
                }
            }
        }
        static GameObject Instantiate(string name, List<Component> components)
        {
            GameObject gameObject = new GameObject(name, components);
            CycleMaster.gameObjects.Add(gameObject);
            return gameObject;
        }
        static GameObject Instantiate(string name)
        {
            GameObject gameObject = new GameObject(name);
            CycleMaster.gameObjects.Add(gameObject);
            return gameObject;
        }
    }
}
