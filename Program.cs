﻿using SDL2;
using Snake;
using System;
using System.Collections;
using System.Linq;

public class Program
{
    static readonly string WINDOW_TITLE = "SNAKE";
    const int w = 600;
    const int h = 480;
    static void Main(string[] args)
    {
        Game.Start(w, h, WINDOW_TITLE);
    }
}