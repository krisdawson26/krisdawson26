using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    public class CourseInfo
    {
        public void Info()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Ellesmere Port Golf Club");
            Console.WriteLine("Par:     71");
            Console.WriteLine("Yardage: 5969");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(" ");
            printHoles();
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("1.   Return to Main Menu");
            Console.WriteLine("2.   Quit");
            options();
        }

        

        public void printHoles()
        { 
            var n = 0;

            while (n <= 17)
            {
                Console.WriteLine("Hole Number:     " + holeArrays.holeNumber[n]);
                Console.WriteLine("Yardage:         " + holeArrays.yardage[n]);
                Console.WriteLine("Par:             " + holeArrays.par[n]);
                Console.WriteLine("Stroke Index:    " + holeArrays.index[n]);
                Console.WriteLine(" ");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine(" ");
                n++;
            }
        }

        public void options()
        {
            string entry = Console.ReadLine();

            if (entry != "1" && entry != "2")
            {
                Console.WriteLine("That is not a valid input. Please try again...");
                options();
            }
            else if (entry == "1")
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
    }

    public class holeArrays
    {

        public static string[] holeNumber = new string[18] { "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                                       "10", "11", "12", "13", "14", "15", "16", "17", "18" };

        public static string[] yardage = new string[18] { "409", "475", "372", "311", "178", "158", "259", "393", "498",
                                                    "355", "490", "178", "283", "176", "368", "417", "173", "476" };

        public static string[] par = new string[18] { "4", "5", "4", "4", "3", "3", "4", "4", "5",
                                                "4", "5", "3", "4", "3", "4", "4", "3", "5" };

        public static string[] index = new string[18] { "8", "12", "4", "6", "14", "16", "18", "2", "10", "3", "13", "15", "17", "9", "5", "1", "7", "11" };

    }
}
