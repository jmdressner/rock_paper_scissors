using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Game
    {
        // member variables

        public Player player1;
        public Player player2;
        public string player1Score;
        public string player2Score;
        public string input;
        

        public Game()
        {
           
        }

        // member methods

        public void RunGame()
        {
            player1 = new Human("");
            player1.SetName();
            Console.WriteLine("Would you like to enter a second player or play against the computer? Please enter 'human' or 'computer'.");
            input = Console.ReadLine().ToLower();

            if (input == "human")
            {
                player2 = new Human("");
                player2.SetName();
 
            }
            else if (input == "computer")
            {
                player2 = new Computer("Brian");
                player2.DisplayName();
            }
            else
            {
                Console.WriteLine("That is not a valid input.  The computer will be your oponent");
                Console.ReadLine();
                player2 = new Computer("Brian");
            }

            player1Score = player1.MakeGestureChoice();
            player2Score = player2.MakeGestureChoice();

            // start best of three - loop
            // player 1 make choice- save answers (member variable to hold this result)
            // player 2 makes choice
            // compare choices -method 
            // display winner- method
            // updates the rounds won
            // display the winner (2/3)

        }



    }
}
