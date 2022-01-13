using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for(int i = 0; i < alphabet.Length; i++)
            {
                if(alphabet[i] == 'q' || alphabet[i] == 'e')
                    continue;
                Console.Write(alphabet[i]);
            }
            
        }
    }
}
