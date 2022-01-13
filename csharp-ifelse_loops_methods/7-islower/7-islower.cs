using System;

public class Character
{
    public static bool IsLower(char c)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        for(int i = 0; i < alphabet.Length; i++)
            if(c == alphabet[i])
                return true;
        return false;        
    }
}
