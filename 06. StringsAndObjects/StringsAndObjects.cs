using System;

class StringsAndObjects
{
    static void Main()
    {
        Console.Title = "Strings and Objects";
        string hello = "Hello";
        string world = "World";
        object sbor = hello + " " + world + "!";
        string print = (string)sbor;
        Console.WriteLine(print);
    }
}

