using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spock
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Welcome and ask the user how many games they would like to play.
            //

            Console.Write("Welcome to the game of Rock Paper Scissors Lizard Spock" + "\n" + "\n" + "\n" + "How many matches do you want for this game set ? Please select from 1 or 3 or 5: ");

            string GameNumSelect = Console.ReadLine();

            //
            // Declare Variables for each game option
            //

            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";
            string lizard = "lizard";
            string spock = "spock";

            //
            // Declare input for computer and associate variables.
            //

            Random rn = new Random();
            int aRandom = rn.Next(1, 5);

            // Declare Variable for each random choice that the computer can choose.

            string computerChoice;
            if (aRandom == 1)
            {
                computerChoice = "r";
            }
            else if (aRandom == 2)
            {
                computerChoice = "p";
            }
            else if (aRandom == 3)
            {
                computerChoice = "s";
            }
            else if (aRandom == 4)
            {
                computerChoice = "l";
            }
            else
            {
                computerChoice = "sp";
            }

            //
            // Convert game number selection to an integer value to be used in the first loop.
            //

            int GameNumSelectConv = Convert.ToInt32(GameNumSelect);
            
            //
            //Match 1 loop
            //

            while (GameNumSelectConv == 1)
            {
                Console.Clear();
            //
            // Introduce Match 1 and receive user input.
            //
            Console.Write("Match 1" + "\n" + "\n" + "Enter (r)ock, (p)aper, (s)cissors, (l)izard, or spoc(k):");
            string userChoice = Console.ReadLine();

                if (userChoice == "r")
                {
                    userChoice = rock;
                }
                else if (userChoice == "p")
                {
                    userChoice = paper;
                }
                else if (userChoice == "s")
                {
                    userChoice = scissors;
                }
                else if (userChoice == "l")
                {
                    userChoice = lizard;
                }
                else if (userChoice == "k")
                {
                    userChoice = spock;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please press any key to re-enter.");
                }

                string userChoiceLong;
                if (computerChoice == "r")
                {
                    computerChoice = rock;
                }
                else if (computerChoice == "p")
                {
                    computerChoice = paper;
                }
                else if (computerChoice == "s")
                {
                    computerChoice = scissors;
                }
                else if (computerChoice == "l")
                {
                    computerChoice = lizard;
                }
                else
                {
                    computerChoice = spock;
                }
            //
            // Evaluate who wins within the Match 1 loop.
            //
                if ((computerChoice == rock && (userChoice == scissors)) ||
                          ((computerChoice == rock) && (userChoice == lizard)) ||
                          ((computerChoice == scissors) && (userChoice == paper)) ||
                          ((computerChoice == scissors) && (userChoice == lizard)) ||
                          ((computerChoice == paper) && (userChoice == rock)) ||
                          ((computerChoice == paper) && (userChoice == scissors)) ||
                          ((computerChoice == lizard) && (userChoice == paper)) ||
                          ((computerChoice == lizard) && (userChoice == scissors)) ||
                          ((computerChoice == spock) && (userChoice == rock)) ||
                          ((computerChoice == spock) && (userChoice == scissors)))
                           {
                    // Computer Wins
                    Console.WriteLine("Computer plays " + computerChoice + ". " + "You play " + userChoice + ". " + " Computer wins.");
                            }
                if ((computerChoice == scissors && (userChoice == rock)) ||
                          ((computerChoice == lizard) && (userChoice == rock)) ||
                          ((computerChoice == paper) && (userChoice == scissors)) ||
                          ((computerChoice == lizard) && (userChoice == scissors)) ||
                          ((computerChoice == rock) && (userChoice == paper)) ||
                          ((computerChoice == scissors) && (userChoice == paper)) ||
                          ((computerChoice == paper) && (userChoice == lizard)) ||
                          ((computerChoice == scissors) && (userChoice == lizard)) ||
                          ((computerChoice == rock) && (userChoice == spock)) ||
                          ((computerChoice == scissors) && (userChoice == spock)))
                {
                    // User Wins
                    Console.WriteLine("Computer plays " + computerChoice + ". " + "You play " + userChoice + ". " + " You win.");
                }
                if ((computerChoice == scissors && (userChoice == scissors)) ||
                          ((computerChoice == lizard) && (userChoice == lizard)) ||
                          ((computerChoice == paper) && (userChoice == paper)) ||
                          ((computerChoice == rock) && (userChoice == rock)) ||
                          ((computerChoice == spock) && (userChoice == spock)))
                {
                    // Tie game
                    Console.WriteLine("Computer plays " + computerChoice + ". " + "You play " + userChoice + ". " + " It is a tie.");
                }
                break;

            }
               

    
            //
            // Give invalid input if user input is not equal to 1 3 or 5
            //

            Console.ReadKey();
            }
        }
    } 
