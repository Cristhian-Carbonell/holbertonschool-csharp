using System;

namespace _1_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int number = rndm.Next(-10000, 10000);
	        int last = number % 10;
            string ret = string.Format("The last digit of {0} is {1} ", number, last);
            if(last > 5)
                Console.WriteLine($"{ret} and is greater than 5");
            else if(last == 0)
                Console.WriteLine($"{ret} and is 0");
            else
                Console.WriteLine($"{ret} and is less than 6 and not 0");
            
        }
    }
}
