using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while(number <= 98)
            {
                Console.WriteLine($"{number} = 0x{number:x}");
                number++;
            }
        }
    }
}
