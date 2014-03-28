using System;

class VarInHexFormat
{
    static void Main()
    {
        Console.Title = "Variable in Hexadecimal Format";
        int aHex = 0xFE;
        Console.WriteLine("Според калкулатора {0}={1}. ;-)", aHex.GetHashCode(), aHex.ToString("X"));
    }
}

