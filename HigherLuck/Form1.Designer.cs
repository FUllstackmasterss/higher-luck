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
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.Initializations = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameArea.SuspendLayout();
            this.grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            this.grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.Initializations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.roundText);
            this.gameArea.Controls.Add(this.turnText);
            this.gameArea.Controls.Add(this.rollButton);
            this.gameArea.Controls.Add(this.firstDiceText);
            this.gameArea.Controls.Add(this.secondDiceText);
            this.gameArea.Location = new System.Drawing.Point(30, 487);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(616, 397);
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
            this.secondDiceText.Click += new System.EventHandler(this.secondDiceText_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(714, 594);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(160, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START (test)";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(904, 594);
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
            this.grpPlayer1.Location = new System.Drawing.Point(714, 25);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(250, 125);
            this.grpPlayer1.TabIndex = 3;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "First player";
            this.grpPlayer1.Enter += new System.EventHandler(this.grpPlayer1_Enter);
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint1.Location = new System.Drawing.Point(139, 40);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(52, 55);
            this.lblPoint1.TabIndex = 4;
            this.lblPoint1.Text = "0";
            this.lblPoint1.Click += new System.EventHandler(this.label1_Click);
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
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblPoint2);
            this.grpPlayer2.Controls.Add(this.picPlayer2);
            this.grpPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayer2.Location = new System.Drawing.Point(714, 174);
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
            this.lblPoint2.Size = new System.Drawing.Size(52, 55);
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
            // Initializations
            // 
            this.Initializations.Controls.Add(this.numericUpDown1);
            this.Initializations.Controls.Add(this.textBox3);
            this.Initializations.Controls.Add(this.textBox2);
            this.Initializations.Controls.Add(this.label3);
            this.Initializations.Controls.Add(this.label2);
            this.Initializations.Controls.Add(this.label1);
            this.Initializations.Location = new System.Drawing.Point(30, 25);
            this.Initializations.Name = "Initializations";
            this.Initializations.Size = new System.Drawing.Size(616, 412);
            this.Initializations.TabIndex = 5;
            this.Initializations.TabStop = false;
            this.Initializations.Text = "Initializations";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(299, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Player Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rounds";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.Initializations);
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
            this.Initializations.ResumeLayout(false);
            this.Initializations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        private GroupBox grpPlayer1;
        private PictureBox picPlayer1;
        private Label lblPoint1;
        private GroupBox grpPlayer2;
        private Label lblPoint2;
        private PictureBox picPlayer2;
        private GroupBox Initializations;
        private Label label1;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}