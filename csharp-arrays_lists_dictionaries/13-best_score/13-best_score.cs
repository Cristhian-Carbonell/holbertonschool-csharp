using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int number = 0;
        string name = "";
        if (myList.Count == 0) {
            return "None";
        }
        foreach (KeyValuePair<string, int> kvp in myList) {
            if (number > kvp.Value) {
                continue;
            }
            else {
                number = kvp.Value;
                name = kvp.Key;
            }
        }

        return name;
    }
}
