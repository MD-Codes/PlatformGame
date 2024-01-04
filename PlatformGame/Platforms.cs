using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class Platforms : ISetings
    {
        public int Width { get; }

        public int Height { get; }

        public int PosX { get; set; }
        public int PosY {get; set; }
        public List<Platforms> platformsList = new List<Platforms>();

        public Platforms()
        {
            Width = 25;
            Height = 25;
            
        }
        public void Draw(Graphics canvas)
        {
            Brush brush = Brushes.Black;
            foreach (Platforms platform in platformsList)
            {
                canvas.FillRectangle(brush, new Rectangle
                       (
                       platform.PosX * Width,
                       platform.PosY * Height,
                       platform.Width, platform.Height
                       ));
            }
        }
        public void BottomPlatform()
        {
            for (int i = 0; i < 20; i++)
            {
                Platforms part = new Platforms
                {
                    PosX = i,
                    PosY = 15,
                };
                platformsList.Add(part);
            }
        }
        public void PlatformColision(Player player)
        {
            foreach (Platforms platform in platformsList)
            {
                if (platform.PosY == player.PosY && platform.PosX == player.PosX)
                {
                    player.PosY = platform.PosY - 1;

                }
            }
        }
    }
}
