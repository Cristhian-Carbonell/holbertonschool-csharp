using System;
using System.Linq;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        for(int i = 0; i < length; i++)
            if(i == 0)
                Console.WriteLine("\\");
            else
                Console.WriteLine($"{String.Concat(Enumerable.Repeat(" ", i))}\\");
        Console.Write("\n");
    }
}
