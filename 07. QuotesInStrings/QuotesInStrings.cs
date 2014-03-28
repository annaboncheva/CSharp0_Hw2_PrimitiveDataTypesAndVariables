using System;

class QuotesInStrings
{
    static void Main()
    {
        Console.Title = "Quotes in String";
        string without = "The \"use\" of quotations causes difficulties."; // Малко не ми е ясно кое е without,
        string with = @"The ""use"" of quotations causes difficulties.";   // кое - with...
        Console.WriteLine("{0}\n{1}", with, without);
    }
}

