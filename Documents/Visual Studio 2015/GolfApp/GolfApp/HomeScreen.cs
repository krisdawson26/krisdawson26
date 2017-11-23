using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    public class HomeScreen
    {
        string selection = "";
        public void mainMenu()
        {
            Console.WriteLine("Welcome to the Ellesport Port Golf Club tracker app.");
            Console.WriteLine("Please select an option below or type \"Quit\" to exit:");
            Console.WriteLine("1.   View Course Information");
            Console.WriteLine("2.   Play a Round");
            Console.WriteLine("3.   See Past Scores on the Course");
            validateSelection();
        }

        public void validateSelection()
        {
            selection = Console.ReadLine().ToLower();

            if (selection != "1" && selection != "2" && selection != "3" && selection != "quit" && selection == "")
            {
                Console.WriteLine("That is not a valid input. Please try again...");
                validateSelection();

            }
            else if (selection == "1")
            {
                CourseInfo courseInfo = new CourseInfo();
                courseInfo.Info();
            }
            else if (selection == "2")
            {
                PlayRound playRound = new PlayRound();
                playRound.addRound();
            }
            else if (selection == "3")
            {
                ScoreLog scoreLog = new ScoreLog();
                scoreLog.printScores();
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
