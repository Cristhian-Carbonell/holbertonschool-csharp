using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] newArray;
        int number = size - 1;
        if (size == 0) {
            Console.WriteLine("");
        }
        else if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        newArray = new int[size];
        for (int i = 0; i < size; i++) {
            newArray[i] = i;
            
            if (number == i) {
                Console.WriteLine("{0}", newArray[i]);
            }
            else {
                Console.Write("{0} ", newArray[i]);
            }
        }

        return newArray;
    }
}
