using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public class Work
    {
        public void Count()
        {
            Console.WriteLine("Thread 1 Starts.\n");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(2000);
            }
            Console.WriteLine("\nThread 1 Ends.");
        }

        public void Alphabet()
        {
            Console.WriteLine("Thread 2 Starts.");
            for(char c = 'a'; c <= 'g'; c++)
            {
                Console.WriteLine(c);
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nThread 2 ends.");
        }

    }
}
