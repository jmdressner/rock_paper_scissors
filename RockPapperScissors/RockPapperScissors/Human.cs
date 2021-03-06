﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Human : Player
    {
        public string gestureInput;

        public Human(string name)
        {
            this.name = name;
            this.gestureNumber = 0;
        }

        public override int MakeGestureChoice()
        {
            Console.WriteLine("What gesture would you like to make? Please enter one choice: 'Rock', 'Paper', 'Scissors', 'Lizard', 'Spock'.");
            gestureInput = Console.ReadLine().ToLower();

                if (gestures.Contains(gestureInput))
                {
                gestureNumber = gestures.IndexOf(gestureInput);
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please press enter to continue.");
                    Console.ReadLine();
                    MakeGestureChoice();                                   
                }
            return gestureNumber;
        }
    }
}
