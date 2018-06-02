using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Human : Player
    {
        // member variables

        public string gestureInput;

        public Human(string name)
        {
            this.name = name;
        }

        // member methods

        public override string MakeGestureChoice()
        {
            Console.WriteLine("What gesture would you like to make? Please enter one choice: 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'.");
            gestureInput = Console.ReadLine().ToLower();

                if (gestures.Contains(gestureInput))
                {
                    Console.WriteLine("You picked: "+ gestureInput);
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please press enter to continue.");
                    Console.ReadLine();
                    MakeGestureChoice();                                   
                }
            return gestureInput;
        }
    }
}
