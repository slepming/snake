using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.SnakeOptions
{
    public class Snake : ISnake
    {
        public int apple_point;
        public SDL.SDL_Rect SNAKE_HEAD { get; set; } = new SDL.SDL_Rect();
        public int SNAKE_SIZE { get; set; }
        public int SNAKE_POSITION_X { get; set; }
        public int SNAKE_POSITION_Y { get; set; }


        public Snake(int size, int x, int y)
        {
            SNAKE_SIZE = size;
            SNAKE_POSITION_X = x;
            SNAKE_POSITION_Y = y;
        }

        public int[] SNAKE_MOVING()
        {
            return null;
        }

        public int SNAKE_TAIL()
        {
            return 0;
        }
    }
}
