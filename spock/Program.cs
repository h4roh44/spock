using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game Over variables
            int go1 = 0;
            int go2 = 0;
            int go3 = 0;

            while (true)
            {
                Console.Clear();
                Console.Write("Welcome to the game of Rock Paper Scissors Lizard Spock" + "\n" + "\n" + "How many matches do you want for this game set ? Please select from 1 or 3 or 5: ");
                string gamechoice = Console.ReadLine();

                int userWin = 0;
                int computerWin = 0;

                if (gamechoice == "3")
                {
                    userWin = 2;
                    computerWin = 2;
                }
                if (gamechoice == "5")
                {
                    userWin = 3;
                    computerWin = 3;
                }


                // 1 MATCH - COMPLETE
                //
                while ((userWin < 1) && (computerWin < 1))
                {

                    Console.Clear();
                    // Generate Input for computer

                    Random rn = new Random();
                    int aRandom = rn.Next(1, 5);

                    // Declare Variable for each random choice

                    string computerChoice;
                    if (aRandom == 1)
                    {
                        computerChoice = "p";
                    }
                    else if (aRandom == 2)
                    {
                        computerChoice = "r";
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
                        computerChoice = "k";
                    }

                    // Request Input from user

                    Console.Write("Match 1" + "\n" + "\n" + "Select (r)ock, (p)aper, (s)cissors, (l)izard, or spoc(k):");
                    string userChoice = Console.ReadLine();

                    // Turn input into long name for later readback.

                    string userChoiceLong = "s";
                    if (userChoice == "r")
                    {
                        userChoiceLong = "rock";
                    }
                    else if (userChoice == "p")
                    {
                        userChoiceLong = "paper";
                    }
                    else if (userChoice == "s")
                    {
                        userChoiceLong = "scissors";
                    }
                    else if (userChoice == "l")
                    {
                        userChoiceLong = "lizard";
                    }
                    else if (userChoice == "k")
                    {
                        userChoiceLong = "spock";
                    }

                    string computerLong = "s";
                    if (computerChoice == "r")
                    {
                        computerLong = "rock";
                    }
                    else if (computerChoice == "p")
                    {
                        computerLong = "paper";
                    }
                    else if (computerChoice == "s")
                    {
                        computerLong = "scissors";
                    }
                    else if (computerChoice == "l")
                    {
                        computerLong = "lizard";
                    }
                    else if (computerChoice == "k")
                    {
                        computerLong = "spock";
                    }

                    // Evaluate winner, or tie.

                    if ((computerChoice == "r") && (userChoice == "r")
                        || ((computerChoice == "p") && (userChoice == "p"))
                        || ((computerChoice == "s")) && (userChoice == "s")
                        || ((computerChoice == "l") && (userChoice == "l"))
                        || ((computerChoice == "k") && (userChoice == "k")))
                    {
                        Console.WriteLine("\n" + "You play " + userChoiceLong + "." + " Computer plays " + computerLong + "." + "What are the odds! It is a tie");
                    }

                    else if ((computerChoice == "r") && (userChoice == "s")
                        || ((computerChoice == "r") && (userChoice == "l"))
                        || ((computerChoice == "p") && (userChoice == "r"))
                        || ((computerChoice == "p") && (userChoice == "k"))
                        || ((computerChoice == "s") && (userChoice == "p"))
                        || (((computerChoice == "s") && (userChoice == "l")))
                        || ((computerChoice == "l") && (userChoice == "p"))
                        || ((computerChoice == "l") && (userChoice == "k"))
                        || ((computerChoice == "k") && (userChoice == "s"))
                        || ((computerChoice == "k") && (userChoice == "r")))
                    {
                        Console.WriteLine("\n" + "You play " + userChoiceLong + " Computer plays " + computerLong + "." + " Computer Wins");
                        computerWin = computerWin + 1;
                    }

                    else if ((computerChoice == "s") && (userChoice == "r")
                        || ((computerChoice == "l") && (userChoice == "r"))
                        || ((computerChoice == "r") && (userChoice == "p"))
                        || ((computerChoice == "k") && (userChoice == "p"))
                        || ((computerChoice == "p") && (userChoice == "s"))
                        || (((computerChoice == "l") && (userChoice == "s")))
                        || ((computerChoice == "p") && (userChoice == "l"))
                        || ((computerChoice == "k") && (userChoice == "l"))
                        || ((computerChoice == "s") && (userChoice == "k"))
                        || ((computerChoice == "r") && (userChoice == "k")))
                    {
                        Console.WriteLine("\n" + "You play " + userChoiceLong + " Computer plays " + computerLong + "." + " You win.");
                        userWin = userWin + 1;
                    }

                    // Declare winner after 1 round.    

                    if (userWin == 1)
                    {
                        Console.WriteLine("\n" + "Out of 1 round(s), the computer won " + computerWin + " round(s) and you won " + userWin + " round(s). You win!");
                    }
                    else if (computerWin == 1)
                    {
                        Console.WriteLine("\n" + "Out of 1 round(s), the computer won " + computerWin + " round(s) and you won " + userWin + " round(s). The computer wins. :(");
                    }
                }

                // Ask for another match
                if ((userWin == 1) || ((computerWin == 1)))
                {
                    Console.WriteLine("\n" + "Enter Y/y to start another game.");
                    string i = Console.ReadLine();
                    if ((i == "Y") || (i == "y"))
                    {
                        userWin = 0;
                        computerWin = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("See you later. Bye");
                        Console.ReadKey();
                        break;
                    }

                    continue;
                }

                //
                // END OF MATCH 1


                // 3 MATCHES - COMPLETE
                //

                int userOverall3 = 0;
                int computerOverall3 = 0;
                int tie = 0;
                int matchNum = 1;

                while ((userWin == 2) && (computerWin == 2))
                {
                    Console.Clear();

                    // Generate Input for computers random choice.

                    Random rn = new Random();
                    int aRandom = rn.Next(1, 5);

                    // Declare Game Variable for each random choice computer can choose.

                    string computerChoice;
                    if (aRandom == 1)
                    {
                        computerChoice = "p";
                    }
                    else if (aRandom == 2)
                    {
                        computerChoice = "r";
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
                        computerChoice = "k";
                    }

                    // Request Input from user for their game choice

                    Console.Write("Match " + matchNum + "\n" + "\n" + "Select (r)ock, (p)aper, (s)cissors, (l)izard, or spoc(k):");

                    string userChoice = Console.ReadLine();

                    // Turn user input into long name for later readback.

                    string userChoiceLong = "s";
                    if (userChoice == "r")
                    {
                        userChoiceLong = "rock";
                    }
                    else if (userChoice == "p")
                    {
                        userChoiceLong = "paper";
                    }
                    else if (userChoice == "s")
                    {
                        userChoiceLong = "scissors";
                    }
                    else if (userChoice == "l")
                    {
                        userChoiceLong = "lizard";
                    }
                    else if (userChoice == "k")
                    {
                        userChoiceLong = "spock";
                    }

                    // Turn computer input into long name for later readback.

                    string computerLong = "s";
                    if (computerChoice == "r")
                    {
                        computerLong = "rock";
                    }
                    else if (computerChoice == "p")
                    {
                        computerLong = "paper";
                    }
                    else if (computerChoice == "s")
                    {
                        computerLong = "scissors";
                    }
                    else if (computerChoice == "l")
                    {
                        computerLong = "lizard";
                    }
                    else if (computerChoice == "k")
                    {
                        computerLong = "spock";
                    }

                    // Evaluate winner, or tie.

                    // TIE GAME

                    if ((computerChoice == "r") && (userChoice == "r")
                        || ((computerChoice == "p") && (userChoice == "p"))
                        || ((computerChoice == "s")) && (userChoice == "s")
                        || ((computerChoice == "l") && (userChoice == "l"))
                        || ((computerChoice == "k") && (userChoice == "k")))
                    {
                        Console.WriteLine("\n" + "You play " + userChoiceLong + "." + " Computer plays " + computerLong + "." + " It is a tie");
                        matchNum = matchNum + 1;
                        tie = tie + 1;

                        if ((tie == 2) || (((computerOverall3 == 1) && (userOverall3 == 1)) && (tie == 1)))
                        {
                            Console.Write("What are the odds! It is a tie!");
                            Console.WriteLine("\n" + " Enter Y/y for another match");
                            string i = Console.ReadLine();
                            if ((i == "Y") || (i == "y"))
                            {
                                break;
                            }
                            else
                            {
                                go1 = go1 + 1;
                                Console.Clear();
                                Console.Write("See you later. Bye");
                                Console.ReadKey();
                                break;
                            }
                        }

                        if (matchNum != 4)
                        {
                            Console.Write("Press any key to next match: ");
                            Console.ReadLine();

                            continue;
                        }

                        break;


                    }
                    // COMPUTER WIN
                    else if ((computerChoice == "r") && (userChoice == "s")
                        || ((computerChoice == "r") && (userChoice == "l"))
                        || ((computerChoice == "p") && (userChoice == "r"))
                        || ((computerChoice == "p") && (userChoice == "k"))
                        || ((computerChoice == "s") && (userChoice == "p"))
                        || (((computerChoice == "s") && (userChoice == "l")))
                        || ((computerChoice == "l") && (userChoice == "k"))
                        || ((computerChoice == "l") && (userChoice == "p"))
                        || ((computerChoice == "k") && (userChoice == "s"))
                        || ((computerChoice == "k") && (userChoice == "r")))
                    {
                        Console.WriteLine("\n" + "You play " + userChoiceLong + "." + " Computer plays " + computerLong + "." + " Computer Wins" + "\n");
                        computerOverall3 = computerOverall3 + 1;
                        matchNum = matchNum + 1;
                        if (computerOverall3 == 2)
                        {
                            matchNum = matchNum - 1;
                            Console.WriteLine("\n" + "Out of " + matchNum + " round(s), the computer won " + computerOverall3 + " round(s) and you won " + userOverall3 + " round(s). The computer wins. :(");
                            Console.WriteLine("\n" + " Enter Y/y for another match");
                            string i = Console.ReadLine();
                            if ((i == "Y") || (i == "y"))
                            {
                                break;
                            }
                            else
                            {
                                go2 = go2 + 1;
                                Console.Clear();
                                Console.Write("See you later. Bye");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (matchNum != 4)
                        {
                            Console.Write("\n" + "Press any key to next match: ");

                            Console.ReadLine();
                            continue;

                        }

                        break;
                    }
                    // USER WIN
                    else if ((computerChoice == "s") && (userChoice == "r")
                       || ((computerChoice == "l") && (userChoice == "r"))
                       || ((computerChoice == "r") && (userChoice == "p"))
                       || ((computerChoice == "k") && (userChoice == "p"))
                       || ((computerChoice == "p") && (userChoice == "s"))
                       || (((computerChoice == "l") && (userChoice == "s")))
                       || ((computerChoice == "p") && (userChoice == "l"))
                       || ((computerChoice == "k") && (userChoice == "l"))
                       || ((computerChoice == "s") && (userChoice == "k"))
                       || ((computerChoice == "r") && (userChoice == "k")))
                    {
                        Console.WriteLine("You play " + userChoiceLong + "." + " Computer plays " + computerLong + "." + " You win." + "\n");
                        userOverall3 = userOverall3 + 1;
                        matchNum = matchNum + 1;
                        if (userOverall3 == 2)
                        {
                            matchNum = matchNum - 1;
                            Console.WriteLine("\n" + "Out of " + matchNum + " round(s), the computer won " + computerOverall3 + " round(s) and you won " + userOverall3 + " round(s). You win!");
                            Console.WriteLine("\n" + " Enter Y/y for another match");
                            string i = Console.ReadLine();
                            if ((i == "Y") || (i == "y"))
                            {
                                break;
                            }
                            else
                            {
                                go3 = go3 + 1;
                                Console.Clear();
                                Console.Write("See you later. Bye");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (matchNum != 4)
                        {
                            Console.Write("\n" + "Press any key to next match: ");
                            Console.ReadLine();
                            continue;
                        }

                        break;


                    }
                }
                //
                // END OF 3 MATCH


                // MATCH 5
                //

                int userOverall5 = 0;
                int computerOverall5 = 0;
                int tie5 = 0;

                while ((userWin == 3) && (computerWin == 3))
                {
                    Console.Clear();

                    // Generate Input for computers random choice.

                    Random rn = new Random();
                    int aRandom = rn.Next(1, 5);

                    // Declare Game Variable for each random choice computer can choose.

                    string computerChoice;
                    if (aRandom == 1)
                    {
                        computerChoice = "p";
                    }
                    else if (aRandom == 2)
                    {
                        computerChoice = "r";
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
                        computerChoice = "k";
                    }

                    // Request Input from user for their game choice

                    Console.Write("Match " + matchNum + "\n" + "\n" + "Select (r)ock, (p)aper, (s)cissors, (l)izard, or spoc(k):");

                    string userChoice = Console.ReadLine();

                    // Turn user input into long name for later readback.

                    string userChoiceLong = "s";
                    if (userChoice == "r")
                    {
                        userChoiceLong = "rock";
                    }
                    else if (userChoice == "p")
                    {
                        userChoiceLong = "paper";
                    }
                    else if (userChoice == "s")
                    {
                        userChoiceLong = "scissors";
                    }
                    else if (userChoice == "l")
                    {
                        userChoiceLong = "lizard";
                    }
                    else if (userChoice == "k")
                    {
                        userChoiceLong = "spock";
                    }

                    // Turn computer input into long name for later readback.

                    string computerLong = "s";
                    if (computerChoice == "r")
                    {
                        computerLong = "rock";
                    }
                    else if (computerChoice == "p")
                    {
                        computerLong = "paper";
                    }
                    else if (computerChoice == "s")
                    {
                        computerLong = "scissors";
                    }
                    else if (computerChoice == "l")
                    {
                        computerLong = "lizard";
                    }
                    else if (computerChoice == "k")
                    {
                        computerLong = "spock";
                    }

                    // Evaluate winner, or tie.

                    // TIE GAME
                    if ((computerChoice == "r") && (userChoice == "r")
                        || ((computerChoice == "p") && (userChoice == "p"))
                        || ((computerChoice == "s")) && (userChoice == "s")
                        || ((computerChoice == "l") && (userChoice == "l"))
                        || ((computerChoice == "k") && (userChoice == "k")))
                    {
                        Console.WriteLine("\n" + "You play " + userChoiceLong + "." + " Computer plays " + computerLong + "." + " It is a tie" + "\n" + "\n");
                        matchNum = matchNum + 1;
                        tie5 = tie5 + 1;

                        if ((tie5 == 3) || ((tie5 == 2 && computerOverall5 == 2 && userOverall5 == 1) || ((tie5 == 2 && computerOverall5 == 1 && userOverall5 == 2) || (((computerOverall5 == 2) && (userOverall5 == 2)) && (tie5 == 1)))))
                        {
                            Console.Write("What are the odds! It is a tie!");
                            Console.WriteLine("\n" + " Enter Y/y for another match");
                            string i = Console.ReadLine();
                            if ((i == "Y") || (i == "y"))
                            {
                                break;
                            }
                            else
                            {
                                go1 = go1 + 1;
                                Console.Clear();
                                Console.Write("See you later. Bye");
                                Console.ReadKey();
                                break;
                            }

                            break;

                        }

                        if (matchNum != 6)
                        {
                            Console.Write("\n" + "Press any key to next match: ");
                            Console.ReadLine();

                            continue;
                        }
                    }
                    // COMPUTER WIN
                    else if ((computerChoice == "r") && (userChoice == "s")
                        || ((computerChoice == "r") && (userChoice == "l"))
                        || ((computerChoice == "p") && (userChoice == "r"))
                        || ((computerChoice == "p") && (userChoice == "k"))
                        || ((computerChoice == "s") && (userChoice == "p"))
                        || (((computerChoice == "s") && (userChoice == "l")))
                        || ((computerChoice == "l") && (userChoice == "k"))
                        || ((computerChoice == "l") && (userChoice == "p"))
                        || ((computerChoice == "k") && (userChoice == "s"))
                        || ((computerChoice == "k") && (userChoice == "r")))
                    {
                        Console.WriteLine("\n" + " You play " + userChoiceLong + " Computer plays " + computerLong + "." + " Computer Wins");
                        computerOverall5 = computerOverall5 + 1;
                        matchNum = matchNum + 1;
                        if (computerOverall5 == 3)
                        {
                            matchNum = matchNum - 1;
                            Console.WriteLine("\n" + "Out of " + matchNum + " round(s), the computer won " + computerOverall5 + " round(s) and you won " + userOverall5 + " round(s). The computer wins. :(");
                            Console.WriteLine("\n" + " Enter Y/y for another match");
                            string i = Console.ReadLine();
                            if ((i == "Y") || (i == "y"))
                            {
                                break;
                            }
                            else
                            {
                                go2 = go2 + 1;
                                Console.Clear();
                                Console.Write("See you later. Bye");
                                Console.ReadKey();
                                break;
                            }

                            break;

                        }
                        if (matchNum != 6)
                        {
                            Console.Write("Press any key to next match: ");

                            Console.ReadLine();
                            continue;

                        }
                    }
                    // USER WIN
                    else if ((computerChoice == "s") && (userChoice == "r")
                       || ((computerChoice == "l") && (userChoice == "r"))
                       || ((computerChoice == "r") && (userChoice == "p"))
                       || ((computerChoice == "k") && (userChoice == "p"))
                       || ((computerChoice == "p") && (userChoice == "s"))
                       || (((computerChoice == "l") && (userChoice == "s")))
                       || ((computerChoice == "p") && (userChoice == "l"))
                       || ((computerChoice == "k") && (userChoice == "l"))
                       || ((computerChoice == "s") && (userChoice == "k"))
                       || ((computerChoice == "r") && (userChoice == "k")))
                    {
                        Console.WriteLine("\n" + " You play " + userChoiceLong + " Computer plays " + computerLong + "." + " You win.");
                        userOverall5 = userOverall5 + 1;
                        matchNum = matchNum + 1;
                        if (userOverall5 == 3)
                        {
                            matchNum = matchNum - 1;
                            Console.WriteLine("\n" + "Out of " + matchNum + " round(s), the computer won " + computerOverall5 + " round(s) and you won " + userOverall5 + " round(s). You win!");
                            Console.WriteLine("\n" + " Enter Y/y for another match");
                            string i = Console.ReadLine();
                            if ((i == "Y") || (i == "y"))
                            {
                                break;
                            }
                            else
                            {
                                go3 = go3 + 1;
                                Console.Clear();
                                Console.Write("See you later. Bye");
                                Console.ReadKey();
                                break;
                            }

                            break;

                        }
                        if (matchNum != 6)
                        {
                            Console.Write("Press any key to next match: ");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    //
                    // END OF MATCH 5
                    Console.ReadKey();
                }
                if ((go1 == 1) || ((go2 == 1)) || ((go3 == 1)))
                {
                    break;

                }
            }
        }
    }
}


