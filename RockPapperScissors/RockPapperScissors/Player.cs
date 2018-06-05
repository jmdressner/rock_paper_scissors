using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    public abstract class Player
    {
        public string name;
        public string gesture;
        public int score;
        public List<string> gestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spock"};

        public Player()
        {
            this.score = 0;
            this.gesture = "";
        }

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
