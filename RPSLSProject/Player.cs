using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    abstract class Player
    {
        public string name;
        public string choice;

        public List<string> GestureChoices = new List<string>();

        public Player()
        {
            GestureChoices.Add("Rock");
            GestureChoices.Add("Paper");
            GestureChoices.Add("Scissors");
            GestureChoices.Add("Lizard");
            GestureChoices.Add("Spock");
        }

        public abstract void playersChoice();
    }
}
