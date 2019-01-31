using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Demonstrates how you can replace the  C# default constructor with your own,
// custom constructor

    // Book 2 chapter 5 Holding a class responsible p 319 
namespace DemonstrateCustomConstructor
{
    // MyObject -- create a class with a noisy custom constructor
    public class MyObject
    {
        private static MyOtherObject _staticObj = new MyOtherObject();
        private MyOtherObject _dynamicObj;
        public MyObject()
        {
            Console.WriteLine("MyObject constructor starting");
            Console.WriteLine();
            Console.WriteLine();
            _dynamicObj = new MyOtherObject();
            Console.WriteLine("MyObject constructor ending");
        }
    }

    // MyOtherObject
    public class MyOtherObject
    {
        public MyOtherObject()
        {
            Console.WriteLine("MyOtherObject constructing");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starting");
            Console.WriteLine("Creating a local MyObject in Main():");
            MyObject localObject = new MyObject();

            // wait for user
            Console.WriteLine("press enter");
            Console.Read();
        }
    }
}
