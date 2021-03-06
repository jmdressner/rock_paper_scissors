﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Computer : Player
    {
        public Computer(string name)
        {
            this.name = name;
            this.gestureNumber = 0;
        }

        public override void DisplayName()
        {
            Console.WriteLine("Player 2 is the computer.");
            Console.ReadLine();
        }

        public override int MakeGestureChoice()
        {
            Random randNum = new Random();
            int index = randNum.Next(0, 4);
            string computerGesture = gestures[index];
            Console.WriteLine("The computer chose " + computerGesture);
            gestureNumber = gestures.IndexOf(computerGesture);

            return gestureNumber;
        }
    }
}
