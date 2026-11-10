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

        private RadioButton[] avatarRadios;
        private PictureBox[] avatarPictures;
        private readonly string[] avatarFiles = { "Icon01.png", "Icon02.png", "Icon03.png", "Icon04.png" };

        private void SetUpPart3()
        {
            avatarRadios = new[] { radioButton1, radioButton2, radioButton3, radioButton4 };
            avatarPictures = new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

            for (int i = 0; i < avatarRadios.Length; i++)
            {
                RadioButton radio = avatarRadios[i];

                avatarPictures[i].Cursor = Cursors.Hand;
                avatarPictures[i].Click += (s, e) => { if (radio.Enabled) radio.Checked = true; };
                radio.CheckedChanged += AvatarRadio_CheckedChanged;
            }

            ResetPart3();
        }

        private string SelectedAvatarFile()
        {
            for (int i = 0; i < avatarRadios.Length; i++)
            {
                if (avatarRadios[i].Checked && avatarRadios[i].Enabled) return avatarFiles[i];
            }
            return null;
        }

        private void AvatarRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (!radio.Checked) return;

            string file = SelectedAvatarFile();
            if (file == null) return;

            PictureBox target;
            if (player1 == null) target = picPlayer1;
            else if (player2 == null) target = picPlayer2;
            else return;

            target.SizeMode = PictureBoxSizeMode.Zoom;
            target.Image?.Dispose();
            target.Image = LoadImage(file);
        }

        private void LockSelectedAvatar()
        {
            foreach (RadioButton radio in avatarRadios)
            {
                if (radio.Checked)
                {
                    radio.Checked = false;
                    radio.Enabled = false;
                }
            }
        }

        private void btnSetUpFirstPlayer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Enter the first player's name.");
                textBox2.Focus();
                return;
            }

            string avatarFile = SelectedAvatarFile();
            if (avatarFile == null)
            {
                MessageBox.Show("Choose an avatar for the first player.");
                return;
            }

            player1 = new Player(textBox2.Text.Trim().ToUpper(), avatarFile);
            ShowFirstPlayer();

            textBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
            LockSelectedAvatar();
        }

        private void btnSetUpSecondPlayer_Click(object sender, EventArgs e)
        {
            if (player1 == null)
            {
                MessageBox.Show("Set up the first player first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Enter the second player's name.");
                textBox3.Focus();
                return;
            }

            string avatarFile = SelectedAvatarFile();
            if (avatarFile == null)
            {
                MessageBox.Show("Choose an avatar for the second player.");
                return;
            }

            player2 = new Player(textBox3.Text.Trim().ToUpper(), avatarFile);
            ShowSecondPlayer();

            textBox3.Enabled = false;
            button2.Enabled = false;
            LockSelectedAvatar();
            foreach (RadioButton radio in avatarRadios) radio.Enabled = false;
        }

        private void ResetPart3()
        {
            ResetSection4();
            ShowGame();

            textBox2.Clear();
            textBox3.Clear();
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            numericUpDown1.Value = 5;

            foreach (RadioButton radio in avatarRadios)
            {
                radio.Enabled = true;
                radio.Checked = false;
            }

            button1.Enabled = true;
            button2.Enabled = false;
            textBox2.Focus();
        }

        private void gameArea_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUpPart3();
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
            ResetPart3();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                string[] lines = File.ReadAllLines("results.txt");

                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            catch
            {
                MessageBox.Show("No results yet!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
