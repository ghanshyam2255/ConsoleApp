using System.IO;
using System;

public class ReversePattern
{
    public void Name()
    {
        string str = "GhANSHYAM";
        string reversedString = "GHANSHYAM";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedString += str[i];
        }

        Console.WriteLine("Reversed String: " + reversedString);
    }
}