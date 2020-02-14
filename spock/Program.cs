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

            string r = "r";
            string p = "p";
            string s = "s";
            string l = "l";
            string k = "k";

            //
            // Convert game number selection to an integer value.
            //

            int GameNumSelectConv = Convert.ToInt32(GameNumSelect);

            //
            // Make variable for game selection
            //

            string onematch = "1";
            string twomatch = "2";
            string threematch = "3";
            
            //
            //Match 1 if statement
            //

            if (GameNumSelectConv == 1)
            {
            Console.Write("Match 1" + "\n" + "\n" + "Enter (r)ock, (p)aper, (s)cissors, (l)izard, or spoc(k):");
            string userChoice = Console.ReadLine();
                
            }
                else if (GameNumSelect != onematch)
                {
                Console.WriteLine("Oops, invalid input. Please choose from 1, 3, and 5." + "\n" + "\n" + "\n" + "Press any key to continue.");
                }
                else if (GameNumSelect != twomatch)
                {
                Console.WriteLine("Oops, invalid input. Please choose from 1, 3, and 5." + "\n" + "\n" + "\n" + "Press any key to continue.");
                }
                else if (GameNumSelect != threematch)
                {
                Console.WriteLine("Oops, invalid input. Please choose from 1, 3, and 5." + "\n" + "\n" + "\n" + "Press any key to continue.");
                }

    
            //
            // Give invalid input if user input is not equal to 1 3 or 5
            //

            Console.ReadKey();
            }
        }
    } 
