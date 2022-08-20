using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public class Operation
    {
        public static void Add(int num)
        {
            Console.WriteLine("Addition = {0}", num + num);
        }

        public static void Square(int num)
        {
            Console.WriteLine("Square = {0}", num*num);
        }
    }
}
