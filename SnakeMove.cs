using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;

namespace Snake
{
    public class SnakeMove : Snake
    {
        public static void Move(IntPtr renderer, SDL.SDL_Event e, ref SDL.SDL_Rect rect, int GRID_SIZE)
        {
            if (e.key.keysym.sym == SDL.SDL_Keycode.SDLK_a)
            {
                rect.x -= GRID_SIZE;
            }
            if (e.key.keysym.sym == SDL.SDL_Keycode.SDLK_w)
            {
                rect.y -= GRID_SIZE;
            }
            if (e.key.keysym.sym == SDL.SDL_Keycode.SDLK_d)
            {
                rect.x += GRID_SIZE;
            }
            if (e.key.keysym.sym == SDL.SDL_Keycode.SDLK_s)
            {
                rect.y += GRID_SIZE;
            }
        }
    }
}
