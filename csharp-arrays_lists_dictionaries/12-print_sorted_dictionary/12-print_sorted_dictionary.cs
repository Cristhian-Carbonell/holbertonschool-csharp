using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> newDict = new SortedList<string, string>();
        foreach (KeyValuePair<string, string> kvp in myDict) {
            newDict.Add(kvp.Key, kvp.Value);
        }
        foreach (KeyValuePair<string, string> kvp in newDict) {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }
    }
}
