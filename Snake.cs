using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;
using System.Security.Cryptography.X509Certificates;

namespace Snake
{
    public class Snake
    {
        public static void Create(IntPtr renderer, SDL.SDL_Event e,int SNAKE_SIZE, int GRID_SIZE)
        {
            if(renderer != 0 && SNAKE_SIZE > 0)
            {
                SDL.SDL_Rect rect = new SDL.SDL_Rect();
                rect.x = 100;
                rect.y = 100;
                rect.w = SNAKE_SIZE;
                rect.h = SNAKE_SIZE;
                SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
                SnakeMove.Move(renderer,e, ref rect, GRID_SIZE);
                SDL.SDL_RenderFillRect(renderer, ref rect);
            }
            else
            {
                return;
            }
            
        }
    }
}
