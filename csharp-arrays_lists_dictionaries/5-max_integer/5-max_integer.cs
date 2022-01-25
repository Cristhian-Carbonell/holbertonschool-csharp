using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int number = 0;
        int end = myList.Count - 1;

        if (myList.Count == 0) {
            Console.WriteLine("List is empty");
            return -1;
        }
        for (int i = 0; i < myList.Count; i++) {
            if (number > myList[i]) {
                continue;
            }
            else {
                number = myList[i];
            }
        }

        return number;
    }
}
