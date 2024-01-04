using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGame
{
    internal class Player : ISetings
    {
        public int Width { get;  }
        public int Height { get;  }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int jumpSpeed { get; set; }
        public int playerSpeed { get; set; }
        public int force { get; set; }
        public bool goLeft  { get; set; }
        public bool goRight { get; set; }
        public bool jumping { get; set; }
        public Player()
        {
            Width = 25;
            Height = 25;
            PosX = 0;
            PosY = 0;
            playerSpeed = 1;
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
        public void KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
            }
        }
        public void KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;

            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
            }
            
        }
        public void Movment()
        {
            PosY += jumpSpeed;

            if (goLeft == true)
            {
                PosX -= playerSpeed;
            }
            if (goRight == true)
            {
                PosX += playerSpeed;
            }

            if (jumping == true && force > 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {

                jumpSpeed = -3;
                force = 3;
            }
            else
            {
                jumpSpeed = 1;
                force -= 1;
            }
        }
        public void BoardColision(int formWidth, int formHight)
        {
            if (PosX <= 0)
            {
                PosX = 0;
                goLeft = false;
            }
            if (PosY <= 0)
            {
                PosY = 0;
                jumping = false;
            }
            if (PosX > (formWidth / 25))
            {
                PosX = formWidth / 25;
                goRight = false;
            }
            if (PosY > (formHight / 25))
            {
                PosY = (formHight / 25);
                jumping = false;
            }
        }

    }
}
