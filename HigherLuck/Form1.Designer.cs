using System;
using System.Drawing;
using System.Windows.Forms;

namespace HigherLuck
{
    partial class Form1
    {
        private GroupBox gameArea;

        private Label roundText;
        private Label turnText;
        private Label firstDiceText;
        private Label secondDiceText;

        private Button rollButton;
        private Button startButton;
        private Button resetButton;

        private void InitializeComponent()
        {
            this.gameArea = new System.Windows.Forms.GroupBox();
            this.roundText = new System.Windows.Forms.Label();
            this.turnText = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.firstDiceText = new System.Windows.Forms.Label();
            this.secondDiceText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.gameArea.SuspendLayout();
            this.grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            this.grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.roundText);
            this.gameArea.Controls.Add(this.turnText);
            this.gameArea.Controls.Add(this.rollButton);
            this.gameArea.Controls.Add(this.firstDiceText);
            this.gameArea.Controls.Add(this.secondDiceText);
            this.gameArea.Location = new System.Drawing.Point(15, 65);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(350, 280);
            this.gameArea.TabIndex = 0;
            this.gameArea.TabStop = false;
            this.gameArea.Text = "Game";
            this.gameArea.Enter += new System.EventHandler(this.gameArea_Enter);
            // 
            // roundText
            // 
            this.roundText.Location = new System.Drawing.Point(15, 25);
            this.roundText.Name = "roundText";
            this.roundText.Size = new System.Drawing.Size(320, 25);
            this.roundText.TabIndex = 0;
            // 
            // turnText
            // 
            this.turnText.AutoEllipsis = true;
            this.turnText.BackColor = System.Drawing.Color.Black;
            this.turnText.ForeColor = System.Drawing.Color.White;
            this.turnText.Location = new System.Drawing.Point(15, 60);
            this.turnText.Name = "turnText";
            this.turnText.Size = new System.Drawing.Size(320, 45);
            this.turnText.TabIndex = 1;
            this.turnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(15, 120);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(320, 35);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "ROLL";
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // firstDiceText
            // 
            this.firstDiceText.AutoEllipsis = true;
            this.firstDiceText.Location = new System.Drawing.Point(15, 175);
            this.firstDiceText.Name = "firstDiceText";
            this.firstDiceText.Size = new System.Drawing.Size(320, 35);
            this.firstDiceText.TabIndex = 3;
            // 
            // secondDiceText
            // 
            this.secondDiceText.AutoEllipsis = true;
            this.secondDiceText.Location = new System.Drawing.Point(15, 220);
            this.secondDiceText.Name = "secondDiceText";
            this.secondDiceText.Size = new System.Drawing.Size(320, 35);
            this.secondDiceText.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(160, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START (test)";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(205, 15);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(160, 35);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "RESET (test)";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.Controls.Add(this.lblPoint1);
            this.grpPlayer1.Controls.Add(this.picPlayer1);
            this.grpPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayer1.Location = new System.Drawing.Point(700, 25);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(250, 125);
            this.grpPlayer1.TabIndex = 3;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "First player";
            this.grpPlayer1.Enter += new System.EventHandler(this.grpPlayer1_Enter);
            // 
            // picPlayer1
            // 
            this.picPlayer1.Location = new System.Drawing.Point(20, 28);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(66, 62);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1.TabIndex = 4;
            this.picPlayer1.TabStop = false;
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint1.Location = new System.Drawing.Point(139, 40);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(54, 58);
            this.lblPoint1.TabIndex = 4;
            this.lblPoint1.Text = "0";
            this.lblPoint1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblPoint2);
            this.grpPlayer2.Controls.Add(this.picPlayer2);
            this.grpPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayer2.Location = new System.Drawing.Point(700, 174);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(250, 125);
            this.grpPlayer2.TabIndex = 4;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Second player";
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint2.Location = new System.Drawing.Point(139, 40);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(54, 58);
            this.lblPoint2.TabIndex = 4;
            this.lblPoint2.Text = "0";
            // 
            // picPlayer2
            // 
            this.picPlayer2.Location = new System.Drawing.Point(20, 28);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(66, 62);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 4;
            this.picPlayer2.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1207, 767);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.gameArea);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Higher Luck - Part 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameArea.ResumeLayout(false);
            this.grpPlayer1.ResumeLayout(false);
            this.grpPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        private GroupBox grpPlayer1;
        private PictureBox picPlayer1;
        private Label lblPoint1;
        private GroupBox grpPlayer2;
        private Label lblPoint2;
        private PictureBox picPlayer2;
    }
}