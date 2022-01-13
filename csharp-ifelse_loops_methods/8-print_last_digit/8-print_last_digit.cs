using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        int digit;

        if(number == 0)
        {
            Console.Write(number);
            return number;
        }
        if(number < 0)
        {
            digit = number % 10 * (-1);
            Console.Write(digit);
        } else {
            digit = number % 10;
            Console.Write(digit);
        }

        return digit;
    }
}
