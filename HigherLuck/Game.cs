using System;

namespace FULL_STACK_MASTERS_Project1
{
    public class Game
    {
        public string firstName = "";
        public string secondName = "";

        public int rounds;
        public int round;
        public int player;

        public int firstDice;
        public int secondDice;

        public int firstPoints;
        public int secondPoints;

        public bool started;
        public bool finished;

        private Random random = new Random();

        public void Start()
        {
            round = 1;
            player = 1;

            firstDice = 0;
            secondDice = 0;

            firstPoints = 0;
            secondPoints = 0;

            started = true;
            finished = false;
        }

        public void Roll()
        {
            if (started == true)
            {
                if (player == 1)
                {
                    firstDice = random.Next(1, 7);
                    secondDice = 0;
                    player = 2;
                }
                else
                {
                    secondDice = random.Next(1, 7);

                    if (firstDice > secondDice)
                    {
                        firstPoints++;
                    }
                    else if (secondDice > firstDice)
                    {
                        secondPoints++;
                    }
                    else
                    {
                        firstPoints++;
                        secondPoints++;
                    }

                    if (round < rounds)
                    {
                        round++;
                        player = 1;
                    }
                    else
                    {
                        started = false;
                        finished = true;
                        player = 0;
                    }
                }
            }
        }

        public void Reset()
        {
            firstName = "";
            secondName = "";

            rounds = 0;
            round = 0;
            player = 0;

            firstDice = 0;
            secondDice = 0;

            firstPoints = 0;
            secondPoints = 0;

            started = false;
            finished = false;
        }
    }
}
