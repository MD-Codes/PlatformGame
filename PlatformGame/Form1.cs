using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGame
{
    public partial class Form1 : Form
    {
        Player player;
        PlatformsLevelOne platformOne;
        DoorLevelOne doorLevelOne;
        CoinsLevelOne coins;
               
        public Form1()
        {
            player = new Player();
            platformOne = new PlatformsLevelOne();
            doorLevelOne = new DoorLevelOne();
            coins = new CoinsLevelOne();
            InitializeComponent();
            GameTimer.Stop();
        }
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            LablePlatformGame.Visible = false;
            buttonStart.Enabled = false;
            buttonStart.Visible = false;
            pictureBox.Visible = true;
            LableScore.Visible = true;
            GameTimer.Start();
        }
        public void MainTimerEvent(object sender, EventArgs e)
        {
            LableScore.Text = "Score: " + player.score;
            player.BoardColision(pictureBox.Width, pictureBox.Height);
            player.Movment();
            platformOne.PlatformColision(player);
            doorLevelOne.DoorColision(player);
            coins.CoinColision(player);
            pictureBox.Invalidate();
        }
        

        public void pictureBoxUpdate(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            platformOne.Draw(canvas);
            doorLevelOne.Draw(canvas);
            coins.Draw(canvas);
            player.Draw(canvas);

        }
        public void KeyIsUp(object sender, KeyEventArgs e)
        {
            player.KeyUp(sender, e);
        }
        public void KeyIsDown(object sender, KeyEventArgs e)
        {
            player.KeyDown(sender, e);
        }
    }
}
