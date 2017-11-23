using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    class PlayRound
    {
        string selection;
        string roundType;
        int startingHole = 1;
        int parScore;
        int par18 = 71;
        int parF9 = 36;
        int parB9 = 35;

        public void addRound()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Play a Round section.");
            Console.WriteLine("Please select an option below or type \"Quit\" to exit:");
            Console.WriteLine("1.   Begin Round");
            Console.WriteLine("2.   Return to Main Menu");
            validateSelection();
        }

        public void validateSelection()
        {
            selection = Console.ReadLine().ToLower();

            if (selection != "1" && selection != "2" && selection != "quit")
            {
                Console.WriteLine("That is not a valid input. Please try again...");
                validateSelection();
            }
            else if (selection == "1")
            {
                begin();
            }
            else if (selection == "2")
            {
                HomeScreen homeScreen = new HomeScreen();
                int x = 0;

                while (x <= 100)
                {
                    Console.WriteLine(" ");
                    x++;
                }
                homeScreen.mainMenu();
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
        }

        public void begin()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Please select an option. ");
            Console.WriteLine("Are you playing: ");
            Console.WriteLine("1.   The full 18 holes?");
            Console.WriteLine("2.   The Front 9?");
            Console.WriteLine("3.   The Back 9?");

            roundType = Console.ReadLine();

            if (roundType != "1" && roundType != "2" && roundType != "3")
            {
                Console.WriteLine("That is not a valid input. Please try again...");
                begin();
            }
            else if (roundType == "3")
            {
                startingHole = 10;
                Score();
            }
            else
            {
                Score();
            }
        }
        
        public void Score()
        {
            int totalScore = 0;
            int score;
            string holeScore;

            Console.WriteLine(" ");

            int n = startingHole - 1;

            if (startingHole == 10)
            {
                while (n <= 17)
                {
                    try
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Hole Number:     " + holeArrays.holeNumber[n]);
                        Console.WriteLine("Yardage:         " + holeArrays.yardage[n]);
                        Console.WriteLine("Par:             " + holeArrays.par[n]);
                        Console.WriteLine("Stroke Index:    " + holeArrays.index[n]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter your score:     ");

                        holeScore = Console.ReadLine().ToLower();

                        if (holeScore == "")
                        {
                            Console.WriteLine("That is not a valid score. Please enter a positive number.");
                        }

                        score = Convert.ToInt32(holeScore);

                        if (score <= 0)
                        {
                            Console.WriteLine("That is not a valid score. Please enter a positive number");
                            holeScore = Console.ReadLine();
                            score = Convert.ToInt32(holeScore);
                        }
                        else
                        {
                            totalScore += score;
                            n++;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid score. Please enter a postive number.");
                        continue;
                    }
                }

                parScore = totalScore - parB9;

                StreamWriter File = new StreamWriter(@"C:\Users\kris.dawson\Documents\Visual Studio 2015\GolfApp\GolfApp\bin\pastScores.txt", true);
                File.WriteLine("You played the Back 9 on " + DateTime.Now + ".\n You posted a score of " + totalScore + " for " + parScore + " against Par." );
                File.WriteLine(" ");
                File.Close();
            }
            else if (roundType == "1")
            {
                while (n <= 17)
                {
                    try
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Hole Number:     " + holeArrays.holeNumber[n]);
                        Console.WriteLine("Yardage:         " + holeArrays.yardage[n]);
                        Console.WriteLine("Par:             " + holeArrays.par[n]);
                        Console.WriteLine("Stroke Index:    " + holeArrays.index[n]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter your score:     ");
                        holeScore = Console.ReadLine();
                        score = Convert.ToInt32(holeScore);

                        if (score <= 0)
                        {
                            Console.WriteLine("That is not a valid score. Please enter a positive number");
                            holeScore = Console.ReadLine();
                            score = Convert.ToInt32(holeScore);
                        }
                        else
                        {
                            totalScore += score;
                            n++;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid score. Please enter a postive number.");
                        continue;
                    }
                }

                parScore = totalScore - par18;

                StreamWriter File = new StreamWriter(@"C:\Users\kris.dawson\Documents\Visual Studio 2015\GolfApp\GolfApp\bin\pastScores.txt", true);
                File.WriteLine("You played 18 holes on " + DateTime.Now + ".\n You posted a score of " + totalScore + " for " + parScore + " against Par.");
                File.WriteLine(" ");
                File.Close();
            }
            else if (roundType == "2")
            {
                while (n <= 8)
                {
                    try
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Hole Number:     " + holeArrays.holeNumber[n]);
                        Console.WriteLine("Yardage:         " + holeArrays.yardage[n]);
                        Console.WriteLine("Par:             " + holeArrays.par[n]);
                        Console.WriteLine("Stroke Index:    " + holeArrays.index[n]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter your score:     ");
                        holeScore = Console.ReadLine();
                        score = Convert.ToInt32(holeScore);

                        if (score <= 0)
                        {
                            Console.WriteLine("That is not a valid score. Please enter a positive number");
                            holeScore = Console.ReadLine();
                            score = Convert.ToInt32(holeScore);
                        }
                        else
                        {
                            totalScore += score;
                            n++;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid score. Please enter a postive number.");
                        continue;
                    }
                }

                parScore = totalScore - parF9;

                StreamWriter File = new StreamWriter(@"C:\Users\kris.dawson\Documents\Visual Studio 2015\GolfApp\GolfApp\bin\pastScores.txt", true);
                File.WriteLine("You played the Front 9 on " + DateTime.Now + ".\n You posted a score of " + totalScore + " for " + parScore + " against Par.");
                File.WriteLine(" ");
                File.Close();
            }

            Console.WriteLine(" ");
            Console.WriteLine("Your total score for the round was " + totalScore + "!");

            if (parScore > 0)
            {
                Console.WriteLine("You were " + parScore + " over par.");
            }
            else if (parScore == 0)
            {
                Console.WriteLine("Your were level Par.");
            }
            else
            {
                Console.WriteLine("You were under par on " + parScore + "!");
            }
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Please select an option below or type \"Quit\" to exit:");
            Console.WriteLine("1.   Begin Round");
            Console.WriteLine("2.   Return to Main Menu");
            validateSelection();
        }
    }
}
