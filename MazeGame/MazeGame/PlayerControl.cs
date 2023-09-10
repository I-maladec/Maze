using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class PlayerControl : Component
    {
        Transform _transform;
        ConsoleKey _ck;
        public override void Start()
        {
            _transform = gameObject.GetComponent<Transform>();
        }
        public override void Update()
        {
            _ck = Master.InputManager.pressedKey;
            switch(_ck)
            {
                case ConsoleKey.W:
                    _transform.Translate(new Vector2int(0, -1));
                    break;
                case ConsoleKey.S:
                    _transform.Translate(new Vector2int(0, 1));
                    break;
                case ConsoleKey.D:
                    _transform.Translate(new Vector2int(1, 0));
                    break;
                case ConsoleKey.A:
                    _transform.Translate(new Vector2int(-1, 0));
                    break;
                default:
                    break;
            }
        }
    }
}
