using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    class HumanPlayer : Player  //using inhertance from player class.
    {
        public override void playersChoice() //overriding inherited method from player class
        {
            Console.WriteLine("Please pick a gesture."); 
            
            for (int i = 0; i<5; i++) //using a for loop to console writeline the 5 gesture choices to the user.
            {
                Console.WriteLine($"Press {i+1} for {GestureChoices[i]}");  
            }
            int userInput = int.Parse(Console.ReadLine()); //capturing user input 
            choice = GestureChoices[userInput - 1];

            bool isNotValid = true;  //using a bool is valid to address bad user input.
            while (isNotValid == true)
            {
                Console.WriteLine("Enter a number between 1-5 for the corresponding gestures");
                int number = int.Parse(Console.ReadLine());
                if (number <=0 || number > 4)
                {
                    Console.WriteLine("That choice is not valid, try again!");
                }
                else
                {
                    isNotValid = false;
                }
            }

        }
    }
}
