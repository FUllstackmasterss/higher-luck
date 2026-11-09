using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HigherLuck
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        private Player player1;
        private Player player2;

        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Maximum = 30;
            numericUpDown1.Minimum = 5;
            numericUpDown1.Value = 5;


            ShowGame();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartPart2(textBox2.Text, textBox3.Text, (int)numericUpDown1.Value);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetPart2();
        }

        public void StartPart2(string firstName, string secondName, int rounds)
        {
            if (game.started == true)
            {
                MessageBox.Show("The game has already started.");
                return;
            }

            if (firstName == null || secondName == null)
            {
                MessageBox.Show("Enter both names.");
                return;
            }

            if (firstName.Trim() == "" || secondName.Trim() == "")
            {
                MessageBox.Show("Enter both names.");
                return;
            }

            if (rounds < 5 || rounds > 30)
            {
                MessageBox.Show("Choose between 5 and 30 rounds.");
                return;
            }

            game.firstName = firstName.Trim();
            game.secondName = secondName.Trim();
            game.rounds = rounds;
            game.Start();
            ShowGame();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            game.Roll();
            ShowGame();
        }

        public void ResetPart2()
        {
            game.Reset();
            ShowGame();
        }

        private void ShowGame()
        {
            roundText.Text = "Round: " + game.round + " / " + game.rounds;
            rollButton.Enabled = game.started;

            if (game.started == true)
            {
                if (game.player == 1)
                {
                    turnText.Text = game.firstName + "'s turn";
                }
                else
                {
                    turnText.Text = game.secondName + "'s turn";
                }
            }
            else if (game.finished == true)
            {
                turnText.Text = "Game finished";
            }
            else
            {
                turnText.Text = "Waiting for START";
            }

            if (game.firstDice == 0)
            {
                firstDiceText.Text = "Player 1: -";
            }
            else
            {
                firstDiceText.Text = game.firstName + ": " + game.firstDice;
            }

            if (game.secondDice == 0)
            {
                secondDiceText.Text = "Player 2: -";
            }
            else
            {
                secondDiceText.Text = game.secondName + ": " + game.secondDice;
            }

            UpdatePoints();
        }   

       
        private static readonly string ImageFolder =
            Path.Combine(Application.StartupPath, "images");

        private const string DefaultAvatar = "default.png";

        private Image LoadImage(string fileName)
        {
            try
            {
                using (var temp = Image.FromFile(Path.Combine(ImageFolder, fileName)))
                {
                    return new Bitmap(temp);   // copy, so the file isn't locked
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load image '" + fileName + "'.\n" + ex.Message,
                                "Image error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void ShowPlayerPanel(Player p, GroupBox grp, PictureBox pic)
        {
            grp.Text = p.Name.ToUpper();
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image?.Dispose();
            pic.Image = LoadImage(p.AvatarFile);
        }

        // Call from "Set Up First Player" after creating player1
        private void ShowFirstPlayer()
        {
            game.firstName = player1.Name;
            ShowPlayerPanel(player1, grpPlayer1, picPlayer1);
            UpdateStartButton();
        }

        // Call from "Set Up Second Player" after creating player2
        private void ShowSecondPlayer()
        {
            game.secondName = player2.Name;
            ShowPlayerPanel(player2, grpPlayer2, picPlayer2);
            UpdateStartButton();
        }

        // Points always come from the Game object
        private void UpdatePoints()
        {
            lblPoint1.Text = game.firstPoints.ToString();
            lblPoint2.Text = game.secondPoints.ToString();
        }

        private void UpdateStartButton()
        {
            startButton.Enabled = (player1 != null && player2 != null);
        }

        // Call from RESET ALL and after a game ends
        private void ResetSection4()
        {
            game.Reset();
            player1 = null;
            player2 = null;

            grpPlayer1.Text = "First Player";
            grpPlayer2.Text = "Second Player";

            picPlayer1.Image?.Dispose();
            picPlayer2.Image?.Dispose();
            picPlayer1.Image = LoadImage(DefaultAvatar);
            picPlayer2.Image = LoadImage(DefaultAvatar);

            UpdatePoints();
            startButton.Enabled = false;
        }

        private void gameArea_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grpPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void secondDiceText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}