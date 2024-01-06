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
            Width = 25;
            Height = 25;
        }

        public void Draw(Graphics canvas)
        {
            Brush brush = Brushes.Green;
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
        public void AddDoor(int posX, int posY)
        {
            Doors door = new Doors
            {
                PosX = posX,
                PosY = posY,
            };
            doors.Add(door);
        }
        public bool DoorColision(Player player)
        {
            foreach (Doors door in doors)
            {
                if (door.PosY == player.PosY && door.PosX == player.PosX)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
