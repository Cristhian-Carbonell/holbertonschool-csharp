using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        int element = 0;

        if (index < 0 || index >= array.Length) {
            Console.WriteLine("Index out of range");
            return -1;
        }
        for (int i = 0; i < array.Length; i++) {
            if (i == index) {
                element = array[i];
                break;
            }
        }

        return element;
    }
}
