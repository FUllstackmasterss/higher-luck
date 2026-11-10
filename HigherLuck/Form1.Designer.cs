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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Report = new System.Windows.Forms.Label();
            this.gameArea.SuspendLayout();
            this.grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            this.grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.Initializations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.roundText);
            this.gameArea.Controls.Add(this.turnText);
            this.gameArea.Controls.Add(this.rollButton);
            this.gameArea.Controls.Add(this.firstDiceText);
            this.gameArea.Controls.Add(this.secondDiceText);
            this.gameArea.Location = new System.Drawing.Point(53, 414);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(422, 282);
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
            this.startButton.Location = new System.Drawing.Point(955, 623);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(160, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START (test)";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1121, 623);
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
            this.grpPlayer1.Location = new System.Drawing.Point(863, 87);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(192, 106);
            this.grpPlayer1.TabIndex = 3;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "First player";
            this.grpPlayer1.Enter += new System.EventHandler(this.grpPlayer1_Enter);
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint1.Location = new System.Drawing.Point(139, 27);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(36, 37);
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
            this.grpPlayer2.Location = new System.Drawing.Point(848, 233);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(207, 111);
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
            this.lblPoint2.Size = new System.Drawing.Size(36, 37);
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
            this.Initializations.Location = new System.Drawing.Point(12, 12);
            this.Initializations.Name = "Initializations";
            this.Initializations.Size = new System.Drawing.Size(528, 369);
            this.Initializations.TabIndex = 5;
            this.Initializations.TabStop = false;
            this.Initializations.Text = "Initializations";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(299, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
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
            this.textBox3.Size = new System.Drawing.Size(270, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Player Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rounds";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(564, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 607);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avatars ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::HigherLuck.Properties.Resources.Icon04;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(122, 468);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 136);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(45, 522);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::HigherLuck.Properties.Resources.Icon03;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(122, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 144);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(45, 394);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HigherLuck.Properties.Resources.Icon02;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(122, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 148);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 276);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HigherLuck.Properties.Resources.Icon01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(122, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 143);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 96);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set Up First player ";
            this.button1.Click += new System.EventHandler(this.btnSetUpFirstPlayer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 763);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Set Up Second player ";
            this.button2.Click += new System.EventHandler(this.btnSetUpSecondPlayer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 824);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 55);
            this.button3.TabIndex = 9;
            this.button3.Text = "RESET ALL ";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(1079, 373);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(194, 82);
            this.BtnReport.TabIndex = 10;
            this.BtnReport.Text = "Show Result";
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1079, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 264);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Location = new System.Drawing.Point(1076, 71);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(39, 13);
            this.Report.TabIndex = 12;
            this.Report.Text = "Report";
            this.Report.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1299, 749);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private PictureBox pictureBox3;
        private RadioButton radioButton3;
        private PictureBox pictureBox2;
        private RadioButton radioButton2;
        private PictureBox pictureBox4;
        private RadioButton radioButton4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button BtnReport;
        private ListBox listBox1;
        private Label Report;
    }
}