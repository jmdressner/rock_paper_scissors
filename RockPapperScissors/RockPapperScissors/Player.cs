using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    public abstract class Player
    {
        // member variables

        public string name;
        public int roundsWon;
        public List<string> gestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spock"};

        public Player()
        {
            
        }

        // member methods

        public virtual void DisplayName()
        {
            Console.WriteLine("Player: " + name);
            Console.ReadLine();
        }

        public void SetName()
        {
            Console.WriteLine("Please enter player name.");
            name = Console.ReadLine();
            DisplayName();
        }

        public abstract string MakeGestureChoice();

        

    }
}
