using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 9; i++)
                for(int j = 0; j <= 9; j++)
                    Console.Write($"{i}{j}, ");
            Console.Write("\n");
        }
    }
}
