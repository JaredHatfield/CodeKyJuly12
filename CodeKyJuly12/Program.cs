using System;

namespace CodeKyJuly12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyCounter myCounter = new MyCounter();

            myCounter.happyCustomer();
            myCounter.sadCustomer();
            myCounter.happyCustomer();


            MyCounter other = new MyCounter();


            Console.WriteLine("Total: " + myCounter.allCustomers());
        }
    }
}

