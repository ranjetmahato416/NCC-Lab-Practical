using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    public class Vehicle
    {
        public string Brand = "Ford";
        public void country()
        {
            Console.WriteLine("USA");
        }
    }

    class Model : Vehicle
    {
        public string ModelName = "Mustang";
    }
}
