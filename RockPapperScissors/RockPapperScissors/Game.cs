﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Game
    {
        // member variables

        public Player player;
        public Human human;
        public Computer computer;
        

        public Game()
        {
            player = new Player();
            human = new Human("");
            computer = new Computer("");
        }

        // member methods

    }
}
