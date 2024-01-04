﻿using System;
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
        public Form1()
        {
            player = new Player();
            InitializeComponent();
            GameTimer.Stop();
        }
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            LablePlatformGame.Visible = false;
            buttonStart.Enabled = false;
            buttonStart.Visible = false;
            pictureBox.Visible = true;
            GameTimer.Start();
        }
        public void MainTimerEvent(object sender, EventArgs e)
        {
            player.Movment();
            pictureBox.Invalidate();
        }
        

        public void pictureBoxUpdate(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
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
