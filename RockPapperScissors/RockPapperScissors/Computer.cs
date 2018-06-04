using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Computer : Player
    {
        // member variables

        public string computerGesture;

        public Computer(string name)
        {
            this.name = name;
        }

        // member methods

        public override void DisplayName()
        {
            Console.WriteLine("Player 2 is the computer.");
            Console.ReadLine();
        }

        public override string MakeGestureChoice()
        {
            Random randNum = new Random();
            int index = randNum.Next(0, 5);
            string value = gestures[index];
            Console.WriteLine("The computer picked "+ value);
            Console.ReadLine();

            return value;
        }
    }
}
