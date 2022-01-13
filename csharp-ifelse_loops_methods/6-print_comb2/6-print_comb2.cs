using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = i; j <= 9; j++)
                {
                    if(i == 8)
                        if(i != j)
                        {
                            Console.WriteLine($"{i}{j}");
                            break;
                        }
                    if(i != j)
                        Console.Write($"{i}{j}, ");
                }
            }
        }
    }
}
