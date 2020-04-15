using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); //creating a new game object called game.
            game.RunGame(); //game object is accesing the RunGame method in Game class.
        }
    }
}
