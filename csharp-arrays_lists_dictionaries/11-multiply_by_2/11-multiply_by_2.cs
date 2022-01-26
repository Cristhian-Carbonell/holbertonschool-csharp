using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        int[] number = new int[myDict.Count];
        string[] name = new string[myDict.Count];
        int count = 0;
        foreach(KeyValuePair<string, int> kvp in myDict) {
            name[count] = kvp.Key;
            number[count] = kvp.Value * 2; 
            count++;
        }
        for (int i = 0; i < name.Length; i++) {
            myDict[name[i]] = number[i];
        }
        
        return myDict;
    }
}
