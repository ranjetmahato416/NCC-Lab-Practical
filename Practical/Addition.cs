using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public class Addition
    {
        public virtual int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    public class ExcAddtion : Addition
    {
        public override int Add(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Value cannot be less than zero.");
                return 0;
            }
            else
            {
                return base.Add(num1, num2);
            }
        }
    }
}
