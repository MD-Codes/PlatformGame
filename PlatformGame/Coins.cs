using System.Collections.Generic;
using System.Drawing;

namespace PlatformGame
{
    internal class Coins : ISetings
    {
        public int Width { get; }

        public int Height { get; }

        public int PosX { get; set; }
        public int PosY { get; set; }
        public List<Coins> coins = new List<Coins>();
        public Coins()
        {
            Width = 25;
            Height = 25;
        }
        public void Draw(Graphics canvas)
        {
            Brush brush = Brushes.Gold;
            foreach (Coins coin in coins)
            {
                canvas.FillEllipse(brush, new Rectangle
                       (
                       coin.PosX * Width,
                       coin.PosY * Height,
                       coin.Width, coin.Height
                       ));
            }
        }
        public void AddCoin(int posX, int posY)
        {
            Coins coin = new Coins
            {
                PosX = posX,
                PosY = posY,
            };
            coins.Add(coin);
        }
        public bool CoinColision(Player player)
        {
            foreach (Coins coin in coins)
            {
                if (coin.PosY == player.PosY && coin.PosX == player.PosX)
                {
                    coins.Remove(coin);
                    return true;
                }
            }
            return false;
        }
    }
}
