using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;

namespace Snake
{
    public class Game
    {
        const int GRID_WIDTH = 100;
        const int GRID_HEIGHT = 100;
        const int GRID_CELL_SIZE = 20;
        const int SNAKE_SIZE = 19;
        public static void Start(int SCREEN_WIDTH, int SCREEN_HEIGHT, string WINDOW_TITLE)
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
            IntPtr window  = SDL.SDL_CreateWindow(WINDOW_TITLE, SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,SCREEN_WIDTH, SCREEN_HEIGHT, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN | SDL.SDL_WindowFlags.SDL_WINDOW_BORDERLESS);
            IntPtr renderer = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);

            IntPtr surf = SDL.SDL_GetWindowSurface(window);
            if(surf == IntPtr.Zero)
            {
                Console.WriteLine("Failed to get window surface " + SDL.SDL_GetError());
            }
            SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
            SDL.SDL_RenderClear(renderer);
            SDL.SDL_Event e;
            bool started = true;
            while (started)
            {
                while (SDL.SDL_PollEvent(out e) != 0)
                {
                    if (e.type == SDL.SDL_EventType.SDL_QUIT)
                    {
                        started = false;
                    }
                    if(e.key.keysym.sym == SDL.SDL_Keycode.SDLK_SPACE)
                    {
                        started = false;
                    }
                }

                SDL.SDL_RenderClear(renderer);
                SDL.SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
                for (int x = (SCREEN_WIDTH / 2) ; x < SCREEN_WIDTH; x += GRID_CELL_SIZE)
                {
                    SDL.SDL_RenderDrawLine(renderer, x, 0, x, SCREEN_HEIGHT);
                }
                for (int y = (SCREEN_HEIGHT / 2); y < SCREEN_HEIGHT; y += GRID_CELL_SIZE)
                {
                    SDL.SDL_RenderDrawLine(renderer, 0, y, SCREEN_WIDTH, y);
                }

                SDL.SDL_Rect rect = new SDL.SDL_Rect();
                rect.x = 100;
                rect.y = 100;
                rect.w = SNAKE_SIZE;
                rect.h = SNAKE_SIZE;
                SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
                SDL.SDL_RenderFillRect(renderer, ref rect);


                SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);

                SDL.SDL_RenderPresent(renderer);

            }



            SDL.SDL_DestroyWindow(window);
            SDL.SDL_RenderClear(renderer);

            SDL.SDL_Quit();
        }
    }
}
