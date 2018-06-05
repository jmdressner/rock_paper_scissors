using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Game
    { 
        public Player player1;
        public Player player2;
        public int roundsWon;
        
        public Game()
        {
            player1 = new Human("");
        }

        public void RunGame()
        {
            roundsWon = 0;
            player1.SetName();
            SetPlayer2();
            GameRounds();
            DisplayWinner();
            PlayGameAgain();
        }

        public void SetPlayer2()
        {
            Console.WriteLine("Would you like to enter a second player or play against the computer? Please enter 'human' or 'computer'.");
            string player2Choice = Console.ReadLine().ToLower();

            if (player2Choice == "human")
            {
                player2 = new Human("");
                player2.SetName();
            }
            else if (player2Choice == "computer")
            {
                player2 = new Computer("The computer");
                player2.DisplayName();
            }
            else
            {
                Console.WriteLine("That is not a valid input. Press enter to continue.");
                Console.ReadLine();
                SetPlayer2();
            }
        }

        public void CompareGestureChoice()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("There was a tie.");
                Console.ReadLine();
            }
            else
            {
                switch (player1.gesture)
                {
                    case "rock":
                        if (player2.gesture == "scissors" || player2.gesture == "lizard")
                        {
                            player1.score += 1;
                            Console.WriteLine(player1.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2.score += 1;
                            Console.WriteLine(player2.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "paper":
                        if (player2.gesture == "rock" || player2.gesture == "spock")
                        {
                            player1.score += 1;
                            Console.WriteLine(player1.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2.score += 1;
                            Console.WriteLine(player2.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "scissors":
                        if (player2.gesture == "paper" || player2.gesture == "lizard")
                        {
                            player1.score += 1;
                            Console.WriteLine(player1.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2.score += 1;
                            Console.WriteLine(player2.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "lizard":
                        if (player2.gesture == "spock" || player2.gesture == "paper")
                        {
                            player1.score += 1;
                            Console.WriteLine(player1.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2.score += 1;
                            Console.WriteLine(player2.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        break;
                    case "spock":
                        if (player2.gesture == "scissors" || player2.gesture == "rock")
                        {
                            player1.score += 1;
                            Console.WriteLine(player1.name + " won round " + (roundsWon + 1));
                            Console.ReadLine();
                            roundsWon += 1;
                        }
                        else
                        {
                            player2.score += 1;
                            Console.WriteLine(player2.name + " won round " + (roundsWon + 1));
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
                player1.gesture = player1.MakeGestureChoice();
                player2.gesture = player2.MakeGestureChoice();
                CompareGestureChoice();
            } 
        }

        public void DisplayWinner()
        {
            if (player1.score >= 2)
            {
                Console.WriteLine(player1.name + " won best of three rounds!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player2.name + " won best of three rounds!");
                Console.ReadLine();
            }
        }

        public void PlayGameAgain()
        {
            Console.WriteLine("Would you like to play again? Please enter 'Yes' or 'No'.");
            string playerInput = Console.ReadLine().ToLower();
            
            if (playerInput == "yes")
            {
                RunGame();
            }
            else if (playerInput == "no")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("That was not a valid input. Please press enter to continue.");
                Console.ReadLine();
                PlayGameAgain();
            }
        }
    }
}
