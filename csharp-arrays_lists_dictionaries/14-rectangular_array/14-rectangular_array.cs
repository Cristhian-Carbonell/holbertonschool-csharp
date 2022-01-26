using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] newArray = new int[5,5];
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (i == 2 && j == 2) {
                        newArray[i,j] = 1;
                    }
                    else {
                        newArray[i,j] = 0;
                    }
                }
            }
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (j == size - 1) {
                        Console.WriteLine("{0}", newArray[i,j]);
                    }
                    else {
                        Console.Write("{0} ", newArray[i,j]);
                    }
                }
            }
        }
    }
}
