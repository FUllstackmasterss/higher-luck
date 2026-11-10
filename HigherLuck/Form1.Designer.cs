using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;



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
            rollButton = new Button();
            firstDiceText = new Label();
            secondDiceText = new Label();
            startButton = new Button();
            resetButton = new Button();
            grpPlayer1 = new GroupBox();
            lblPoint1 = new Label();
            picPlayer1 = new PictureBox();
            grpPlayer2 = new GroupBox();
            lblPoint2 = new Label();
            picPlayer2 = new PictureBox();
            Initializations = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            radioButton4 = new RadioButton();
            pictureBox3 = new PictureBox();
            radioButton3 = new RadioButton();
            pictureBox2 = new PictureBox();
            radioButton2 = new RadioButton();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            BtnReport = new Button();
            listBox1 = new ListBox();
            Report = new Label();
            gameArea.SuspendLayout();
            grpPlayer1.SuspendLayout();
            ((ISupportInitialize)(picPlayer1)).BeginInit();
            grpPlayer2.SuspendLayout();
            ((ISupportInitialize)(picPlayer2)).BeginInit();
            Initializations.SuspendLayout();
            ((ISupportInitialize)(numericUpDown1)).BeginInit();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)(pictureBox4)).BeginInit();
            ((ISupportInitialize)(pictureBox3)).BeginInit();
            ((ISupportInitialize)(pictureBox2)).BeginInit();
            ((ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();

            
            gameArea.Controls.Add(roundText);
            gameArea.Controls.Add(turnText);
            gameArea.Controls.Add(rollButton);
            gameArea.Controls.Add(firstDiceText);
            gameArea.Controls.Add(secondDiceText);
            gameArea.Location = new Point(53, 414);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(422, 282);
            gameArea.TabIndex = 0;
            gameArea.TabStop = false;
            gameArea.Text = "Game";
            gameArea.Enter += new EventHandler(gameArea_Enter);
            

            roundText.Location = new Point(15, 25);
            roundText.Name = "roundText";
            roundText.Size = new Size(320, 25);
            roundText.TabIndex = 0;
            

            turnText.AutoEllipsis = true;
            turnText.BackColor = Color.Black;
            turnText.ForeColor = Color.White;
            turnText.Location = new Point(15, 60);
            turnText.Name = "turnText";
            turnText.Size = new Size(320, 45);
            turnText.TabIndex = 1;
            turnText.TextAlign = ContentAlignment.MiddleLeft;
            

            rollButton.Location = new Point(15, 120);
            rollButton.Name = "rollButton";
            rollButton.Size = new Size(320, 35);
            rollButton.TabIndex = 2;
            rollButton.Text = "ROLL";
            rollButton.Click += new EventHandler(rollButton_Click);
            

            firstDiceText.AutoEllipsis = true;
            firstDiceText.Location = new Point(15, 175);
            firstDiceText.Name = "firstDiceText";
            firstDiceText.Size = new Size(320, 35);
            firstDiceText.TabIndex = 3;
            

            secondDiceText.AutoEllipsis = true;
            secondDiceText.Location = new Point(15, 220);
            secondDiceText.Name = "secondDiceText";
            secondDiceText.Size = new Size(320, 35);
            secondDiceText.TabIndex = 4;
            secondDiceText.Click += new EventHandler(secondDiceText_Click);
            

            startButton.Location = new Point(955, 623);
            startButton.Name = "startButton";
            startButton.Size = new Size(160, 35);
            startButton.TabIndex = 1;
            startButton.Text = "START (test)";
            startButton.Click += new EventHandler(startButton_Click);
            

            resetButton.Location = new Point(1121, 623);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(160, 35);
            resetButton.TabIndex = 2;
            resetButton.Text = "RESET (test)";
            resetButton.Click += new EventHandler(resetButton_Click);
            

            grpPlayer1.Controls.Add(lblPoint1);
            grpPlayer1.Controls.Add(picPlayer1);
            grpPlayer1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            grpPlayer1.Location = new Point(863, 87);
            grpPlayer1.Name = "grpPlayer1";
            grpPlayer1.Size = new Size(192, 106);
            grpPlayer1.TabIndex = 3;
            grpPlayer1.TabStop = false;
            grpPlayer1.Text = "First player";
            grpPlayer1.Enter += new EventHandler(grpPlayer1_Enter);
            
            
            lblPoint1.AutoSize = true;
            lblPoint1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblPoint1.Location = new Point(139, 27);
            lblPoint1.Name = "lblPoint1";
            lblPoint1.Size = new Size(36, 37);
            lblPoint1.TabIndex = 4;
            lblPoint1.Text = "0";
            lblPoint1.Click += new EventHandler(label1_Click);
            

            picPlayer1.Location = new Point(20, 28);
            picPlayer1.Name = "picPlayer1";
            picPlayer1.Size = new Size(66, 62);
            picPlayer1.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer1.TabIndex = 4;
            picPlayer1.TabStop = false;
            
            

            grpPlayer2.Controls.Add(lblPoint2);
            grpPlayer2.Controls.Add(picPlayer2);
            grpPlayer2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            grpPlayer2.Location = new Point(848, 233);
            grpPlayer2.Name = "grpPlayer2";
            grpPlayer2.Size = new Size(207, 111);
            grpPlayer2.TabIndex = 4;
            grpPlayer2.TabStop = false;
            grpPlayer2.Text = "Second player";
            


            lblPoint2.AutoSize = true;
            lblPoint2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblPoint2.Location = new Point(139, 40);
            lblPoint2.Name = "lblPoint2";
            lblPoint2.Size = new Size(36, 37);
            lblPoint2.TabIndex = 4;
            lblPoint2.Text = "0";
            

            picPlayer2.Location = new Point(20, 28);
            picPlayer2.Name = "picPlayer2";
            picPlayer2.Size = new Size(66, 62);
            picPlayer2.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer2.TabIndex = 4;
            picPlayer2.TabStop = false;
            


            Initializations.Controls.Add(numericUpDown1);
            Initializations.Controls.Add(textBox3);
            Initializations.Controls.Add(textBox2);
            Initializations.Controls.Add(label3);
            Initializations.Controls.Add(label2);
            Initializations.Controls.Add(label1);
            Initializations.Location = new Point(12, 12);
            Initializations.Name = "Initializations";
            Initializations.Size = new Size(528, 369);
            Initializations.TabIndex = 5;
            Initializations.TabStop = false;
            Initializations.Text = "Initializations";
            


            numericUpDown1.Location = new Point(299, 69);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 20);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            

            textBox3.Location = new Point(299, 312);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 20);
            textBox3.TabIndex = 6;
            

            textBox2.Location = new Point(299, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 20);
            textBox2.TabIndex = 5;
            

            label3.AutoSize = true;
            label3.Location = new Point(24, 312);
            label3.Name = "label3";
            label3.Size = new Size(107, 13);
            label3.TabIndex = 3;
            label3.Text = "Second Player Name";
            

            label2.AutoSize = true;
            label2.Location = new Point(24, 189);
            label2.Name = "label2";
            label2.Size = new Size(89, 13);
            label2.TabIndex = 2;
            label2.Text = "First Player Name";
            

            label1.AutoSize = true;
            label1.Location = new Point(24, 71);
            label1.Name = "label1";
            label1.Size = new Size(44, 13);
            label1.TabIndex = 1;
            label1.Text = "Rounds";
            label1.Click += new EventHandler(label1_Click_1);
            

            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(564, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 607);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Avatars ";
            groupBox1.Enter += new EventHandler(groupBox1_Enter);
            

            pictureBox4.BackgroundImage = global::HigherLuck.Properties.Resources.Icon04;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(122, 468);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 136);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += new EventHandler(pictureBox4_Click);
            

            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(45, 522);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += new EventHandler(radioButton4_CheckedChanged);
            

            pictureBox3.BackgroundImage = global::HigherLuck.Properties.Resources.Icon03;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(122, 338);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 144);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            

            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(45, 394);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            

            pictureBox2.BackgroundImage = global::HigherLuck.Properties.Resources.Icon02;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(122, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 148);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += new EventHandler(pictureBox2_Click);
           

            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(45, 276);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            

            pictureBox1.BackgroundImage = global::HigherLuck.Properties.Resources.Icon01;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(122, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 143);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new EventHandler(pictureBox1_Click);
            

            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 96);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            

            button1.Location = new Point(624, 648);
            button1.Name = "button1";
            button1.Size = new Size(310, 55);
            button1.TabIndex = 7;
            button1.Text = "Set Up First player ";
            button1.Click += new EventHandler(btnSetUpFirstPlayer_Click);
            

            button2.Location = new Point(683, 763);
            button2.Name = "button2";
            button2.Size = new Size(310, 55);
            button2.TabIndex = 8;
            button2.Text = "Set Up Second player ";
            button2.Click += new EventHandler(btnSetUpSecondPlayer_Click);
            

            button3.Location = new Point(683, 824);
            button3.Name = "button3";
            button3.Size = new Size(310, 55);
            button3.TabIndex = 9;
            button3.Text = "RESET ALL ";
            button3.Click += new EventHandler(button3_Click);
            

            BtnReport.Location = new Point(1079, 373);
            BtnReport.Name = "BtnReport";
            BtnReport.Size = new Size(194, 82);
            BtnReport.TabIndex = 10;
            BtnReport.Text = "Show Result";
            BtnReport.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnReport.UseVisualStyleBackColor = true;
            BtnReport.Click += new EventHandler(BtnReport_Click);
            

            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1079, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 264);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            

            Report.AutoSize = true;
            Report.Location = new Point(1076, 71);
            Report.Name = "Report";
            Report.Size = new Size(39, 13);
            Report.TabIndex = 12;
            Report.Text = "Report";
            Report.Click += new EventHandler(label4_Click);
            

            ClientSize = new Size(1299, 749);
            Controls.Add(Report);
            Controls.Add(listBox1);
            Controls.Add(BtnReport);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(Initializations);
            Controls.Add(grpPlayer2);
            Controls.Add(grpPlayer1);
            Controls.Add(gameArea);
            Controls.Add(startButton);
            Controls.Add(resetButton);
            Name = "Form1";
            Text = "Higher Luck - Part 2";
            Load += new EventHandler(Form1_Load);
            gameArea.ResumeLayout(false);
            grpPlayer1.ResumeLayout(false);
            grpPlayer1.PerformLayout();
            ((ISupportInitialize)(picPlayer1)).EndInit();
            grpPlayer2.ResumeLayout(false);
            grpPlayer2.PerformLayout();
            ((ISupportInitialize)(picPlayer2)).EndInit();
            Initializations.ResumeLayout(false);
            Initializations.PerformLayout();
            ((ISupportInitialize)(numericUpDown1)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)(pictureBox4)).EndInit();
            ((ISupportInitialize)(pictureBox3)).EndInit();
            ((ISupportInitialize)(pictureBox2)).EndInit();
            ((ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

