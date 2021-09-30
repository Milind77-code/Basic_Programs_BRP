using System;

namespace Pattern_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++) //for rows
            {
                for (j = 1; j <= 10; j++) //for col
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
