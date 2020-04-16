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


    }
}
