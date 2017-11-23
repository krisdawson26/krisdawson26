using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    public class ScoreLog
    {
        public void printScores()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\kris.dawson\Documents\Visual Studio 2015\GolfApp\GolfApp\bin\pastScores.txt");

            System.Console.WriteLine("Score Log:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("1.   Return to Main Menu");
            Console.WriteLine("2.   Quit");
            CourseInfo courseInfo = new CourseInfo();
            courseInfo.options();
        }
    }
}
