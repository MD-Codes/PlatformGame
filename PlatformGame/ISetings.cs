using System;
using System.Collections.Generic;
using System.Drawing;

namespace PlatformGame
{
    internal interface ISetings
    {
        int Width { get; }
        int Height { get; }
        int PosX { get; set; }
        int PosY { get; set; }
        
        void Draw(Graphics canvas);
    }
}
