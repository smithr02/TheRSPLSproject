using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    abstract class Player
    {
        public string name;   //variables for what a player HAS
        public int score;
        public string choice;

        public List<string> GestureChoices = new List<string>(); //created a list and stored it as GestureChoices

        public Player()   //constructor thats adding in the 5 gestures to be ussed.
        {
            GestureChoices.Add("Rock");
            GestureChoices.Add("Paper");
            GestureChoices.Add("Scissors");
            GestureChoices.Add("Lizard");
            GestureChoices.Add("Spock");
        }

        public abstract void playersChoice();  //parent method to be used by child classes, humanplayer and computerplayer.
    }
}
