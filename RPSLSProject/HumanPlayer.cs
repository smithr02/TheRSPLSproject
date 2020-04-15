using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    class HumanPlayer : Player
    {
        public override void playersChoice()
        {
            Console.WriteLine("Please pick a gesture."); 
            
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Press {i+1} for {GestureChoices[i]}");
            }
            int userInput = int.Parse(Console.ReadLine());
            choice = GestureChoices[userInput - 1];

            bool isValid = false;
            while (isValid)
            {
                Console.WriteLine("Enter a number between 1-5 for the corresponding gestures");
                int number = int.Parse(Console.ReadLine());
                if (number <=0 || number > 4)
                {
                    Console.WriteLine("That choice is not valid, try again!");
                }
                else
                {
                    isValid = false;
                }
            }

        }
    }
}
