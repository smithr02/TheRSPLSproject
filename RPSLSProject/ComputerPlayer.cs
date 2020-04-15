using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    class ComputerPlayer : Player
    {
        public override void playersChoice()  //overridden parent player class method
        {
            Random rand = new Random(); //created a random object called rand, which picks between 1-5 of the list GestureChoices.
            int chosenGesture = rand.Next(0, 5);
            choice = GestureChoices[chosenGesture];
        }
    }
}
