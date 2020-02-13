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
            // Wlecome and ask the user how many games they would like to play.
            //

            Console.WriteLine("Welcome to the game of Rock Paper Scissors Lizard Spock" + "\n" + "\n" + "\n" + "How many matches do you want for this game set ? Please select from 1 or 3 or 5: ");

            string GameNumSelect = Console.ReadLine();

            // Give invalid input if user input is not equal to 1 3 or 5
            //

            int GameNumSelectConv = Convert.ToInt32(GameNumSelect);

            if (GameNumSelectConv != 1)
            {
                Console.WriteLine("Oops, invalid input. Please choose from 1, 3, and 5." + "\n" + "\n" + "\n" + "Press any key to continue.");
            }
            else if (GameNumSelectConv != 3)
            {
                Console.WriteLine("Oops, invalid input. Please choose from 1, 3, and 5." + "\n" + "\n" + "\n" + "Press any key to continue.");
            }

            else if (GameNumSelectConv < 10)
            {
                Console.WriteLine("Oops, invalid input. Please choose from 1, 3, and 5." + "\n" + "\n" + "\n" + "Press any key to continue.");

            }

            Console.ReadKey();
        }
    }
}
