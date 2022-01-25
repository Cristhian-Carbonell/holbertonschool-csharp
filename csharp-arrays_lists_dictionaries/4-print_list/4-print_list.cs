using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int number = size - 1;
        if (size == 0) {
            Console.WriteLine("");
        }
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> newList = new List<int>();
        for (int i = 0; i < size; i++) {
            newList.Add(i);
            if (i == number) {
                Console.WriteLine("{0}", newList[i]);
            }
            else {
                Console.Write("{0} ", newList[i]);
            }
        }

        return newList;
    }
}
