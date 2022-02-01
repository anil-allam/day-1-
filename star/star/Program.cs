using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 3; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}
