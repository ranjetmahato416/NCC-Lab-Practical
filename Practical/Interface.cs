using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public interface IFirstInterface
    {
        void myMethod();
    }

    public interface ISecondInterface
    {
        void myOtherMethod();
    }

    class InterfaceClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("First method through First Interface");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Second Method through Second Interface");
        }
    }
}
