using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] newArray;
        if (size == 0) {
            Console.WriteLine("");
            newArray = new int[size];
            return newArray;
        }
        else if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        newArray = new int[size];
        for (int i = 0; i < size; i++) {
            newArray[i] = i;
            Console.Write("{0} ", newArray[i]);
        }
        Console.Write("\n");

        return newArray;
    }
}
