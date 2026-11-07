using System;
using System.Windows.Forms;

namespace HigherLuck
{
    public partial class Form1 : Form
    {
        Game game = new Game();

        public Form1()
        {
            InitializeComponent();
            ShowGame();
        }

        
        private void startButton_Click(object sender, EventArgs e)
        {
            StartPart2("Player 1", "Player 2", 5);
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
        }

       
       
    }
}

