using System.Collections.Generic;
namespace Practical
{
    public class Program
    {
        //delegate void DelOps(int x);
        static void Main(string[] args)
        {
            //Multithreading & Multitasking
            Work w = new Work();
            Console.WriteLine("\nMain thread starts now.");
            ThreadStart s1 = w.Count;
            ThreadStart s2 = w.Alphabet;
            Thread thread1 = new Thread(s1);
            Thread thread2 = new Thread(s2);
            thread1.Start();
            thread2.Start();
            Console.WriteLine("\nMain thread ends now.");
            Console.ReadLine();


            //GenericQueue
           /* Queue<int> my_queue = new Queue<int>();
            my_queue.Enqueue(1);
            my_queue.Enqueue(22);
            my_queue.Enqueue(13);
            my_queue.Enqueue(42);
            my_queue.Enqueue(15);
            my_queue.Enqueue(63);

            foreach (int i in my_queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nDequeuing '{0}'", my_queue.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}",
                my_queue.Peek());
            Console.WriteLine("Dequeuing '{0}'", my_queue.Dequeue());
            Console.WriteLine("Total items in " + "my_queue is {0}", my_queue.Count);*/


            //GenericStack
            //Stack<int> my_stack = new Stack<int>();
            //my_stack.Push(23);
            //my_stack.Push(3);
            //my_stack.Push(423);
            //my_stack.Push(56);
            //my_stack.Push(9);

            //foreach (var elem in my_stack)
            //{
            //  Console.WriteLine(elem);
            //}
            //Console.WriteLine("Total elements present in" +
            //      " my_stack: {0}", my_stack.Count);

            //Console.WriteLine("Topmost element of my_stack " +
            //                "is: {0}", my_stack.Peek());

            //my_stack.Pop();

            //Console.WriteLine("After pop operation Total elements present " +
            //   "in my_stack: {0}", my_stack.Count);


            //delegates
            //DelOps obj = Operation.Add;
            //obj(10);
            //obj += Operation.Square;
            //obj(4);


            //Multiple Inheritance using Interface
            //InterfaceClass myInterface = new InterfaceClass();
            //myInterface.myMethod();
            //myInterface.myOtherMethod();

            //overridding
            //Addition myAdd;
            //myAdd = new Addition();
            //Console.WriteLine("Base Class method add: " + myAdd.Add(-2,3));
            //myAdd = new ExcAddtion();
            //Console.WriteLine("Child Class method add: " + myAdd.Add(2,3));
            //Console.WriteLine("Child Class method add: " + myAdd.Add(2,-3));

            //Overloading
            //Operations myops = new Operations();
            //Console.WriteLine("Sum with two integers: " + myops.Add(3, 4));
            //Console.WriteLine("Sum with three integers: " + myops.Add(3, 4, 6));
            //Console.WriteLine("Sum with two double: " + myops.Add(3.34, 4.23));
            //Console.WriteLine("Sum with two strings: " + myops.Add("Hello", "World"));

            //Inheritance
            //Model mymodel = new Model();
            //mymodel.country();
            //Console.WriteLine(mymodel.Brand + " " + mymodel.ModelName);

            //Class And Object
            //Car myobj = new Car();
            //Console.WriteLine(myobj.Brand);
            //Console.WriteLine(myobj.Name);
        }
    }

    public class Car
    {
        public string Brand = "Dodge";
        public string Name = "HellCat";
    }

}