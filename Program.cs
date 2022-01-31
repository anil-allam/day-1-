using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age:");
            age = int.Parse(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("eligible for vote");
            }
            else
            {
                Console.WriteLine("not eligible for vote");
            }
        }
    }
}
