using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    class ComputerPlayer : Player
    {
        public override void playersChoice()
        {
            Random rand = new Random();
            int chosenGesture = rand.Next(0, 5);
            choice = GestureChoices[chosenGesture];
        }
    }
}
