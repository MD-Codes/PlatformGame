using System;
using System.Collections.Generic;
using System.Drawing;

namespace PlatformGame
{
    internal class Doors : ISetings
    {
        public int Width { get; }

        public int Height { get; }

        public int PosX { get; set; }
        public int PosY { get; set; }
        public List<Doors> doors = new List<Doors>();
        public Doors()
        {
            Width = 20;
            Height = 25;
        }

        public void Draw(Graphics canvas)
        {
            Brush brush = Brushes.Black;
            foreach (Doors door in doors)
            {
                canvas.FillRectangle(brush, new Rectangle
                       (
                       PosX * Width,
                       PosY * Height,
                       Width, Height
                       ));
            }
        }
    }
}
