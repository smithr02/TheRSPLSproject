using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    class Game
    {
        public Player PlayerOne;   //setting up a new player object and variables for score of each player and the winningScore.
        public Player PlayerTwo;
        public int PlayerOneScore;
        public int PlayerTwoScore;
        public int WinningScore;

        public Game()
        {
            WinningScore = 3;
        }

        public void RunGame()  //rungame method which will run all the methods in logical order to run the game properly.
        {
            Instructions();
            TypeOfPlayer();

            while (DeterminingWinner())
            {
                PlayerOne.playersChoice();
                PlayerTwo.playersChoice();
                ComparingGestures();
            }
        }

        public void Instructions()
        {
            Console.WriteLine("Welcome to RPSLS,the following comparisons are how to win: 1)Rock crushes Scissors 2) Scissors cuts Paper 3) Paper covers Rock 4) Rock crushes Lizard 5)Lizard poisons Spock 6)Spock smashes Scissors 7)Scissors decapitates Lizard 8) Lizard eats Paper 9) Paper disaproves Spock 10)Spock vaporizes Rock ");
            Console.ReadLine();
        }

        public void TypeOfPlayer()
        {
            int choice;
            Console.WriteLine("Enter 1 for HumanPlayer vs ComputerPlayer or enter 2 for HumanPlayer vs HumanPlayer.");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                PlayerOne = new HumanPlayer();
                PlayerTwo = new ComputerPlayer();
                Console.WriteLine("The game now is HumanPlayer vs ComputerPlayer. Good Luck!");
            }
            else if(choice == 2)
            {
                PlayerOne = new HumanPlayer();
                PlayerTwo = new HumanPlayer();
                Console.WriteLine("The game is now HumanPlayer vs HumanPlayer. May the best human win!");
            }


        }
        public void ComparingGestures()
        {
            if (PlayerOne.choice == "Rock" && PlayerTwo.choice == "Scissors")
            {
                PlayerOneScore++;
                Console.WriteLine("Player one wins this round");
            }
            else if (PlayerOne.choice == "Rock" && PlayerTwo.choice == "Lizard")
            {
                PlayerOneScore++;
                Console.WriteLine("Player one wins this round");
            }
            else if (PlayerOne.choice == "Rock" && PlayerTwo.choice == "Paper")
            {
                PlayerTwoScore++;
                Console.WriteLine("Player two wins this round");
            }
            else if (PlayerOne.choice == "Rock" && PlayerTwo.choice == "Spock")
            {
                PlayerTwoScore++;
                Console.WriteLine("Player two wins this round");
            }
            else if (PlayerOne.choice == "Paper" && PlayerTwo.choice == "Scissors")
            {
                PlayerTwoScore++;
                Console.WriteLine("Player two wins this round");
            }
            else if (PlayerOne.choice == "Paper" && PlayerTwo.choice == "Spock")
            {
                PlayerOneScore++;
                Console.WriteLine("Player one wins this round");
            }
            else if (PlayerOne.choice == "Paper" && PlayerTwo.choice == "Lizard")
            {
                PlayerTwoScore++;
                Console.WriteLine("Player two wins this round");
            }
            else if (PlayerOne.choice == "Scissors" && PlayerTwo.choice == "Lizard")
            {
                PlayerOneScore++;
                Console.WriteLine("Player one wins this round");
            }
            else if (PlayerOne.choice == "Lizard" && PlayerTwo.choice == "Spock")
            {
                PlayerOneScore++;
                Console.WriteLine("Player one wins this round");
            }
            else if (PlayerOne.choice == "Spock" && PlayerTwo.choice == "Scissors")
            {
                PlayerOneScore++;
                Console.WriteLine("Player one wins this round");
            }
            else
            {
                Console.WriteLine("This is a tie!");
                Console.ReadLine();
            }
        }

        public bool DeterminingWinner()
        {
            if (PlayerOneScore == WinningScore)
            {
                Console.WriteLine("Player one wins the game!!!");
                Console.ReadLine();

                return false;
            }
            else if (PlayerTwoScore == WinningScore)
            {
                Console.WriteLine("Player two wins the game!!!");
                Console.ReadLine();

                return false;
            }
            else
            {
                return true;
            }
                

        }


    }
}
