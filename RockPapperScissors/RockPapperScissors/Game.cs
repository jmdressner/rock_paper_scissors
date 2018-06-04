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
        public string player1Gesture;
        public string player2Gesture;
        public int player1Score = 0;
        public int player2Score = 0;
        public string input;
        public int roundsWon = 0;
        

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

            GameRounds();

            DisplayWinner();

            

            // start best of three - loop
            // player 1 make choice- save answers (member variable to hold this result)
            // player 2 makes choice
            // compare choices -method 
            // display winner- method
            // updates the rounds won
            // display the winner (2/3)

        }

        public void CompareGestureChoice()
        {
            if (player1Gesture == player2Gesture)
            {
                Console.WriteLine("There was a tie.");
                Console.ReadLine();
            }
            else
            {

                switch (player1Gesture)
                {
                    case "rock":
                        if (player2Gesture == "scissors" || player2Gesture == "lizard")
                        {
                            player1Score += 1;
                            Console.WriteLine("Player 1 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2Score += 1;
                            Console.WriteLine("Player 2 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "paper":
                        if (player2Gesture == "rock" || player2Gesture == "spock")
                        {
                            player1Score += 1;
                            Console.WriteLine("Player 1 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2Score += 1;
                            Console.WriteLine("Player 2 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "scissors":
                        if (player2Gesture == "paper" || player2Gesture == "lizard")
                        {
                            player1Score += 1;
                            Console.WriteLine("Player 1 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2Score += 1;
                            Console.WriteLine("Player 2 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "lizard":
                        if (player2Gesture == "spock" || player2Gesture == "paper")
                        {
                            player1Score += 1;
                            Console.WriteLine("Player 1 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2Score += 1;
                            Console.WriteLine("Player 2 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "spock":
                        if (player2Gesture == "scissors" || player2Gesture == "rock")
                        {
                            player1Score += 1;
                            Console.WriteLine("Player 1 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2Score += 1;
                            Console.WriteLine("Player 2 won");
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    default:
                        Console.WriteLine("There was an error and no result could be reached.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public void GameRounds()
        {
            while (roundsWon < 3)
            {
                player1Gesture = player1.MakeGestureChoice();
                player2Gesture = player2.MakeGestureChoice();
                CompareGestureChoice();
            }
            
        }

        public void DisplayWinner()
        {
            if (player1Score >= 2)
            {
                Console.WriteLine("Player 1 won best of three!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player 2 won best of three!");
                Console.ReadLine();
            }

        }
       
    }
}
