using System;
using System.Text;

namespace _6_print_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = new StringBuilder("Hoberton School".Length * 3).Insert(0, "Hoberton School", 3).ToString();
            string characters = str.Substring(0, 9);
            Console.WriteLine("{0}\n{1}", str, characters);
        }
    }
}
