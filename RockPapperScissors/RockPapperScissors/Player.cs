using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Player
    {
        // member variables

        public string name;

        public Player()
        {

        }

        // member methods

        public virtual void DisplayName()
        {
            Console.WriteLine("Person1: " + name);
            Console.ReadLine();
        }

        public void SetName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            DisplayName();
        }
    }
}
