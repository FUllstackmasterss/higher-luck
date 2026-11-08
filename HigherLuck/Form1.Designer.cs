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
            gameArea = new GroupBox();

            roundText = new Label();
            turnText = new Label();
            firstDiceText = new Label();
            secondDiceText = new Label();

            rollButton = new Button();
            startButton = new Button();
            resetButton = new Button();

            SuspendLayout();

            gameArea.Text = "Game";
            gameArea.Location = new Point(15, 65);
            gameArea.Size = new Size(350, 280);

            roundText.Location = new Point(15, 25);
            roundText.Size = new Size(320, 25);

            turnText.Location = new Point(15, 60);
            turnText.Size = new Size(320, 45);
            turnText.BackColor = Color.Black;
            turnText.ForeColor = Color.White;
            turnText.AutoEllipsis = true;
            turnText.TextAlign = ContentAlignment.MiddleLeft;

            rollButton.Text = "ROLL";
            rollButton.Location = new Point(15, 120);
            rollButton.Size = new Size(320, 35);
            rollButton.Click += new EventHandler(rollButton_Click);

            firstDiceText.Location = new Point(15, 175);
            firstDiceText.Size = new Size(320, 35);
            firstDiceText.AutoEllipsis = true;

            secondDiceText.Location = new Point(15, 220);
            secondDiceText.Size = new Size(320, 35);
            secondDiceText.AutoEllipsis = true;

            gameArea.Controls.Add(roundText);
            gameArea.Controls.Add(turnText);
            gameArea.Controls.Add(rollButton);
            gameArea.Controls.Add(firstDiceText);
            gameArea.Controls.Add(secondDiceText);

            startButton.Text = "START (test)";
            startButton.Location = new Point(15, 15);
            startButton.Size = new Size(160, 35);
            startButton.Click += new EventHandler(startButton_Click);

            resetButton.Text = "RESET (test)";
            resetButton.Location = new Point(205, 15);
            resetButton.Size = new Size(160, 35);
            resetButton.Click += new EventHandler(resetButton_Click);

            ClientSize = new Size(380, 365);

            Controls.Add(gameArea);
            Controls.Add(startButton);
            Controls.Add(resetButton);

            Text = "Higher Luck - Part 2";

            ResumeLayout(false);
        }
    }
}