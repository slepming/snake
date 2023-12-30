using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.SnakeOptions
{
    public interface ISnake
    {
        SDL.SDL_Rect SNAKE_HEAD { get; set; }
        int SNAKE_SIZE { get; set; }
        int SNAKE_POSITION_X { get; set; }
        int SNAKE_POSITION_Y { get; set; }

        int SNAKE_TAIL();
        int[] SNAKE_MOVING();
    }
}
