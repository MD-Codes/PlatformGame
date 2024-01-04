using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class Player : ISetings
    {
        public int Width { get;  }
        public int Height { get;  }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Player()
        {
            Width = 25;
            Height = 25;
            PosX = 0;
            PosY = 0;
        }
        public void Draw(Graphics canvas)
        {
            Brush brush = Brushes.Gray;
            canvas.FillEllipse(brush, new Rectangle
                   (
                   PosX * Width,
                   PosY * Height,
                   Width, Height
                   ));
        }
    }
}
