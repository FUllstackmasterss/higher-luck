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


            ConfigureLayout();
            ShowGame();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (player1 == null || player2 == null)
            {
                MessageBox.Show("Set up both players first.");
                return;
            }
            StartPart2(player1.Name, player2.Name, (int)numericUpDown1.Value);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetPart3();
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
            numericUpDown1.Enabled = false;
            UpdateStartButton();
            ShowGame();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            if (game.started == false) return;
            game.Roll();
            ShowGame();
            if (game.finished)
            {
                string result = ResultText();
                bool saved = SaveResult(result);
                if (saved == true)
                {
                    MessageBox.Show(result + "\nResult saved.", "Game result");
                }
                else
                {
                    MessageBox.Show(result + "\nResult could not be saved. Record the scores before closing this message.", "Game result");
                }
                ResetPart3();
            }
        }

        public void ResetPart2()
        {
            ResetPart3();
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
                using (Image temp = Image.FromFile(Path.Combine(ImageFolder, fileName)))
                {
                    return new Bitmap(temp);   
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
            if (pic.Image == null)
            {
               
            }
            else
            {
                pic.Image.Dispose();
            }
            pic.Image = LoadImage(p.AvatarFile);
        }

        
        private void ShowFirstPlayer()
        {
            game.firstName = player1.Name;
            ShowPlayerPanel(player1, grpPlayer1, picPlayer1);
            UpdateStartButton();
        }

        
        private void ShowSecondPlayer()
        {
            game.secondName = player2.Name;
            ShowPlayerPanel(player2, grpPlayer2, picPlayer2);
            UpdateStartButton();
        }

        
        private void UpdatePoints()
        {
            lblPoint1.Text = game.firstPoints.ToString();
            lblPoint2.Text = game.secondPoints.ToString();
        }

        private void UpdateStartButton()
        {
            startButton.Enabled = false;
            if (player1 == null || player2 == null)
            {
                return;
            }
            if (game.started == false)
            {
                startButton.Enabled = true;
            }
        }

        
        private void ResetSection4()
        {
            game.Reset();
            player1 = null;
            player2 = null;

            grpPlayer1.Text = "First Player";
            grpPlayer2.Text = "Second Player";

            if (picPlayer1.Image == null)
            {
                
            }
            else
            {
                picPlayer1.Image.Dispose();
            }
            if (picPlayer2.Image == null)
            {
               
            }
            else
            {
                picPlayer2.Image.Dispose();
            }
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
            avatarRadios = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
            avatarPictures = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

            for (int i = 0; i < avatarRadios.Length; i++)
            {
                avatarPictures[i].Cursor = Cursors.Hand;
                avatarPictures[i].Click += new EventHandler(AvatarPicture_Click);
                avatarRadios[i].CheckedChanged += new EventHandler(AvatarRadio_CheckedChanged);
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
            if (radio.Checked == false) 
                
                return;

            string file = SelectedAvatarFile();
            if (file == null)
                
                
                
                return;

            PictureBox target;
            if (player1 == null) target = picPlayer1;


            else if (player2 == null) target = picPlayer2;


            else return;

            target.SizeMode = PictureBoxSizeMode.Zoom;
            if (target.Image == null)
            {
                
            }
            else
            {
                target.Image.Dispose();
            }
            target.Image = LoadImage(file);
        }

        private void LockSelectedAvatar()
        {
            for (int i = 0; i < avatarRadios.Length; i++)
            {
                if (avatarRadios[i].Checked == true)
                {
                    avatarRadios[i].Checked = false;
                    avatarRadios[i].Enabled = false;
                }
            }
        }

        private void btnSetUpFirstPlayer_Click(object sender, EventArgs e)
        {
            if (game.started == true)
            {
                return;
            }

            if (player1 == null)
            {
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Enter the first player's name.");
                    textBox2.Focus();
                    return;
                }

                if (textBox3.Text.Trim() == "")
                {
                    MessageBox.Show("Enter the second player's name.");
                    textBox3.Focus();
                    return;
                }

                string avatarFile = SelectedAvatarFile();

                if (avatarFile == null)
                {
                    MessageBox.Show("Choose an avatar for the first player.");
                    return;
                }

                player1 = new Player(
                    textBox2.Text.Trim().ToUpper(),
                    avatarFile
                );

                ShowFirstPlayer();

                textBox2.Enabled = false;
                button1.Enabled = false;

                LockSelectedAvatar();
                UpdateSetupButtons();
            }
        }

        private void btnSetUpSecondPlayer_Click(object sender, EventArgs e)
        {
            if (game.started == true)
            {
                return;
            }

            if (player1 == null)
            {
                MessageBox.Show("Set up the first player first.");
                return;
            }

            if (player2 == null)
            {
                if (textBox3.Text.Trim() == "")
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

                if (avatarFile == player1.AvatarFile)
                {
                    MessageBox.Show("Choose a different avatar for the second player.");
                    return;
                }

                player2 = new Player(
                    textBox3.Text.Trim().ToUpper(),
                    avatarFile
                );

                ShowSecondPlayer();

                textBox3.Enabled = false;
                button2.Enabled = false;

                LockSelectedAvatar();

                for (int i = 0; i < avatarRadios.Length; i++)
                {
                    avatarRadios[i].Enabled = false;
                }

                UpdateSetupButtons();
            }
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
            numericUpDown1.Enabled = true;
            listBox1.Items.Clear();

            for (int i = 0; i < avatarRadios.Length; i++)
            {
                avatarRadios[i].Enabled = true;
                avatarRadios[i].Checked = false;
            }

            UpdateSetupButtons();
            textBox2.Focus();
        }

        private void gameArea_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUpPart3();
            textBox2.TextChanged += NamesChanged;
            textBox3.TextChanged += NamesChanged;
            UpdateSetupButtons();
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
            listBox1.Items.Clear();
            try
            {
                if (File.Exists(resultPath) == false)
                {
                    listBox1.Items.Add("No saved results yet.");
                    return;
                }
                using (StreamReader file = new StreamReader(resultPath))
                {
                    while (file.EndOfStream == false)
                    {
                        string line = file.ReadLine();
                        listBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not read results: " + error.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        private string resultPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Fullstackmasterss", "HigherLuck", "results.txt");

        private void NamesChanged(object sender, EventArgs e)
        {
            UpdateSetupButtons();
        }

        private void UpdateSetupButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            if (textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || game.started == true)
            {
                UpdateStartButton();
                return;
            }
            if (player1 == null)
            {
                button1.Enabled = true;
            }
            else if (player2 == null)
            {
                button2.Enabled = true;
            }
            UpdateStartButton();
        }

        private string ResultText()
        {
            string winner = "Draw";
            if (game.firstPoints > game.secondPoints) winner = game.firstName;
            else if (game.secondPoints > game.firstPoints) winner = game.secondName;
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " | " +
                game.firstName + ": " + game.firstPoints + " | " +
                game.secondName + ": " + game.secondPoints + " | Rounds: " +
                game.rounds + " | Winner: " + winner;
        }

        private bool SaveResult(string result)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(resultPath));
                using (StreamWriter file = new StreamWriter(resultPath, true))
                {
                    file.WriteLine(result);
                }
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not save results: " + error.Message);
                return false;
            }
        }

        
        private void ConfigureLayout()
        {
            Text = "Fullstackmasterss - Higher Luck";
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1100, 650);
            StartPosition = FormStartPosition.CenterScreen;
            Label teamName = new Label();
            teamName.Text = "Fullstackmasterss";
            teamName.SetBounds(15, 10, 300, 25);
            Controls.Add(teamName);

            Initializations.SetBounds(15, 45, 345, 185);
            label1.SetBounds(15, 35, 100, 25);
            label2.SetBounds(15, 85, 130, 25);
            label3.SetBounds(15, 135, 130, 25);
            numericUpDown1.SetBounds(165, 32, 150, 25);
            textBox2.SetBounds(165, 82, 150, 25);
            textBox3.SetBounds(165, 132, 150, 25);
            gameArea.SetBounds(15, 245, 345, 285);
            groupBox1.SetBounds(375, 45, 180, 375);
            RadioButton[] radios = { radioButton1, radioButton2, radioButton3, radioButton4 };
            PictureBox[] pictures = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            for (int i = 0; i < 4; i++)
            {
                radios[i].SetBounds(15, 55 + i * 85, 20, 20);
                pictures[i].SetBounds(50, 25 + i * 85, 95, 75);
            }
            button1.SetBounds(375, 435, 180, 40);
            button2.SetBounds(375, 485, 180, 40);
            button3.SetBounds(375, 545, 180, 40);
            button1.Text = "Set Up First Player";
            button2.Text = "Set Up Second Player";
            button3.Text = "RESET ALL";
            grpPlayer1.SetBounds(570, 45, 220, 150);
            grpPlayer2.SetBounds(570, 215, 220, 150);
            picPlayer1.SetBounds(15, 30, 100, 100);
            picPlayer2.SetBounds(15, 30, 100, 100);
            lblPoint1.Location = new Point(135, 60);
            lblPoint2.Location = new Point(135, 60);
            startButton.SetBounds(570, 385, 220, 40);
            startButton.Text = "START";
            resetButton.Visible = false;
            Report.Location = new Point(810, 45);
            listBox1.SetBounds(810, 75, 270, 430);
            listBox1.HorizontalScrollbar = true;
            BtnReport.SetBounds(810, 525, 270, 40);
            BtnReport.Text = "SHOW RESULT";
        }

        private void AvatarPicture_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < avatarPictures.Length; i++)
            {
                if (sender == avatarPictures[i] && avatarRadios[i].Enabled == true)
                {
                    avatarRadios[i].Checked = true;
                }
            }
        }

    }
}

