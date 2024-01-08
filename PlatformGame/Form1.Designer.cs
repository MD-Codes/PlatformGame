using System.Windows.Forms.VisualStyles;

namespace PlatformGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.LablePlatformGame = new System.Windows.Forms.Label();
            this.LableScore = new System.Windows.Forms.Label();
            this.LableScoreList = new System.Windows.Forms.Label();
            this.LableScoreOne = new System.Windows.Forms.Label();
            this.LableScoreTwo = new System.Windows.Forms.Label();
            this.LableScoreThree = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(171, 216);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(233, 75);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // LablePlatformGame
            // 
            this.LablePlatformGame.AutoSize = true;
            this.LablePlatformGame.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LablePlatformGame.Location = new System.Drawing.Point(131, 126);
            this.LablePlatformGame.Name = "LablePlatformGame";
            this.LablePlatformGame.Size = new System.Drawing.Size(298, 43);
            this.LablePlatformGame.TabIndex = 3;
            this.LablePlatformGame.Text = "Platform Game";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(562, 528);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxUpdate);
            // 
            // LableScore
            // 
            this.LableScore.AutoSize = true;
            this.LableScore.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableScore.Location = new System.Drawing.Point(400, 5);
            this.LableScore.Name = "LableScore";
            this.LableScore.Size = new System.Drawing.Size(95, 27);
            this.LableScore.TabIndex = 4;
            this.LableScore.Text = "Score: 0";
            this.LableScore.Visible = false;
            // 
            // LableScoreList
            // 
            this.LableScoreList.AutoSize = true;
            this.LableScoreList.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableScoreList.Location = new System.Drawing.Point(131, 75);
            this.LableScoreList.Name = "LableScoreList";
            this.LableScoreList.TabIndex = 4;
            this.LableScoreList.Text = "Scores:";
            this.LableScoreList.Visible = false;
            // 
            // LableScoreOne
            // 
            this.LableScoreOne.AutoSize = true;
            this.LableScoreOne.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableScoreOne.Location = new System.Drawing.Point(131, 125);
            this.LableScoreOne.Name = "LableScoreOne";
            this.LableScoreOne.Size = new System.Drawing.Size(95, 27);
            this.LableScoreOne.TabIndex = 4;
            this.LableScoreOne.Text = "1: ";
            this.LableScoreOne.Visible = false;
            // 
            // LableScoreTwo
            // 
            this.LableScoreTwo.AutoSize = true;
            this.LableScoreTwo.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableScoreTwo.Location = new System.Drawing.Point(131, 175);
            this.LableScoreTwo.Name = "LableScoreTwo";
            this.LableScoreTwo.Size = new System.Drawing.Size(95, 27);
            this.LableScoreTwo.TabIndex = 4;
            this.LableScoreTwo.Text = "2: ";
            this.LableScoreTwo.Visible = false;
            // 
            // LableScoreThree
            // 
            this.LableScoreThree.AutoSize = true;
            this.LableScoreThree.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableScoreThree.Location = new System.Drawing.Point(131, 225);
            this.LableScoreThree.Name = "LableScoreThree";
            this.LableScoreThree.Size = new System.Drawing.Size(95, 27);
            this.LableScoreThree.TabIndex = 4;
            this.LableScoreThree.Text = "3: ";
            this.LableScoreThree.Visible = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 484);
            this.Controls.Add(this.LablePlatformGame);
            this.Controls.Add(this.LableScore);
            this.Controls.Add(this.LableScoreList);
            this.Controls.Add(this.LableScoreOne);
            this.Controls.Add(this.LableScoreTwo);
            this.Controls.Add(this.LableScoreThree);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Platform Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label LablePlatformGame;
        private System.Windows.Forms.Label LableScore;
        private System.Windows.Forms.Label LableScoreList;
        private System.Windows.Forms.Label LableScoreOne;
        private System.Windows.Forms.Label LableScoreTwo;
        private System.Windows.Forms.Label LableScoreThree;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

