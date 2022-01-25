using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        int number = 0;
        if (index < 0 || index >= myList.Count) {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        for (int i = 0; i < myList.Count; i++) {
            if (i == index) {
                number = myList[i];
                myList.Remove(number);
                break;
            }  
        }

        return myList;
    }
}
