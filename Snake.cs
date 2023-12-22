using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Snake
{
    public class Snake
    {
        public static IntPtr renderer;
        public static SDL.SDL_Event e;
        public static int SNAKE_SIZE;
        public static int GRID_SIZE;
        
        public static void Create()
        {
            if(renderer != 0 && SNAKE_SIZE > 0)
            {
                SDL.SDL_Rect rect = new SDL.SDL_Rect();
                rect.x = 101;
                rect.y = 101;
                rect.w = SNAKE_SIZE;
                rect.h = SNAKE_SIZE;
                SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
                SDL.SDL_RenderFillRect(renderer, ref rect);
            }
            else
            {
                return;
            }
            
        }
        static bool Vector(int button) // 1 - w; 2 - s ;3 - d ;4 - a;
        {
            if(button == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
