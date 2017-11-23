using System;
using System.Threading;

namespace GolfApp
{
    class matrix
    {
        public void writeWords()
        {
            int count = 0;

            string[] messages = new string[4]
            {
                "   Wake up, Neo...",
                "   The Matrix has you...",
                "   Follow the white rabbit.",
                "   Knock, knock, Neo!"
            };

            while (count <=3)
            {
                Console.WriteLine(" ");

                foreach (char c in messages[count])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(c);
                    Thread.Sleep(100);
                }

                Thread.Sleep(3000);
                Console.Clear();
                count++;
            }

            Thread.Sleep(2000);
        }
    }
}
