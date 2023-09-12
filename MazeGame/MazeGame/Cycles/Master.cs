using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Master
    {
        public static Master GameMaster = new Master();
        public static World World = new World();
        public static InputManager InputManager = new InputManager();
        private static Camera camera;
        private List<GameObject> gameObjects = new List<GameObject>();
        private List<Component> components = new List<Component>();
        static void Main()
        {
            camera = Instantiate("camera", new List<Component> {new Camera()}).GetComponent<Camera>();
            Instantiate("player", new List<Component> { new Transform(new Vector2int(1, 1)), new CharRenderer('@'), new PlayerControl() });
            Build.BuildFrame(new Vector2int(0, 0), new Vector2int(50, 50), new GameObject("wall", new List<Component> { new CharRenderer('#'), new Solid()}));
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
            for (int i = 0; i < GameMaster.gameObjects.Count; i++)
            {
                GameMaster.components = GameMaster.gameObjects[i].GetComponents();
                for(int j = 0; j < GameMaster.gameObjects[i].GetComponents().Count; j++)
                {
                    GameMaster.components[j].Update();
                }
                GameMaster.gameObjects[i].Update();
            }
        }
        static void MasterStart()
        {
            for (int i = 0; i < GameMaster.gameObjects.Count; i++)
            {
                GameMaster.gameObjects[i].Start();
                GameMaster.components = GameMaster.gameObjects[i].GetComponents();
                for (int j = 0; j < GameMaster.gameObjects[i].GetComponents().Count; j++)
                {
                    GameMaster.components[j].Start();
                }
            }
        }
        public static GameObject Instantiate(string name, List<Component> components)
        {
            GameObject gameObject = new GameObject(name, components);
            GameMaster.gameObjects.Add(gameObject);
            return gameObject;
        }
        public static GameObject Instantiate(string name)
        {
            GameObject gameObject = new GameObject(name);
            GameMaster.gameObjects.Add(gameObject);
            return gameObject;
        }
        public static GameObject Instantiate(GameObject gameObject)
        {
            GameMaster.gameObjects.Add(gameObject);
            return gameObject;
        }
    }
}
