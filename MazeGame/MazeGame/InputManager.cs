using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class InputManager
    {
        public ConsoleKey pressedKey;
        public void Input()
        {
            pressedKey = Console.ReadKey().Key;
        }
    }
}
