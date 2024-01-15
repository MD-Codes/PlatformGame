using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlatformGame
{
    public partial class Form1 : Form
    {
        Player player;
        PlatformLevelOne platformOne;
        DoorLevelOne doorLevelOne;
        CoinsLevelOne coins;
        JsonData dataScore = new JsonData();
        PlatformLevelThree platformLevelThree = new PlatformLevelThree();
        PlatformLevelTwo platformsLevelTwo = new PlatformLevelTwo();
        DoorLevelTwo doorsLevelTwo = new DoorLevelTwo();
        DoorLevelThree doorLevelThree = new DoorLevelThree();
        CoinsLevelTwo coinsLevelTwo = new CoinsLevelTwo();
        CoinsLevelThree coinsLevelThree = new CoinsLevelThree();
        private int level { get; set; }
         

        public Form1()
        {
            dataScore.ReadMyFile();
            player = new Player();
            platformOne = new PlatformLevelOne();
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
            level = 1;
            GameTimer.Start();
        }
        public void MainTimerEvent(object sender, EventArgs e)
        {
            LableScore.Text = "Score: " + player.score;
            player.BoardColision(pictureBox.Width, pictureBox.Height);
            player.Movment();
            if (level == 1)
            {
                platformOne.PlatformColision(player);
                if (coins.CoinColision(player))
                {
                    player.score += 1;
                };
                if (doorLevelOne.DoorColision(player))
                {
                    level++;
                    player.PosY = 14;
                };
                
            }else if(level == 2)
            {                
                platformsLevelTwo.PlatformColision(player);
                if (coinsLevelTwo.CoinColision(player))
                {
                    player.score += 1;
                };
                if (doorsLevelTwo.DoorColision(player))
                {
                    level++;
                    player.PosY = 14;
                };
            }else if(level == 3)
            {
                
                platformLevelThree.PlatformColision(player);
                if (coinsLevelThree.CoinColision(player))
                {
                    player.score += 1;
                };
                if (doorLevelThree.DoorColision(player))
                {
                    dataScore.AddScore(player.score);
                    level++;
                };
            }            
            pictureBox.Invalidate();
        }
        public void pictureBoxUpdate(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (level == 1)
            {
                platformOne.Draw(canvas);
                doorLevelOne.Draw(canvas);
                coins.Draw(canvas);

            }
            else if (level == 2)
            {
                platformsLevelTwo.Draw(canvas);
                doorsLevelTwo.Draw(canvas);
                coinsLevelTwo.Draw(canvas);
            }
            else if (level == 3)
            {
                platformLevelThree.Draw(canvas);
                doorLevelThree.Draw(canvas);
                coinsLevelThree.Draw(canvas);
                
            }
            else if(level == 4)
            {
                
                LableScoreList.Visible = true;
                LableScoreOne.Visible = true;
                LableScoreOne.Text = "1: " + dataScore.ReturnValue(0);
                LableScoreTwo.Visible = true;
                LableScoreTwo.Text = "2: " + dataScore.ReturnValue(1);
                LableScoreThree.Visible = true;
                LableScoreThree.Text = "3: " + dataScore.ReturnValue(2);

                player.PosX = -1;
               
            }
            
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
