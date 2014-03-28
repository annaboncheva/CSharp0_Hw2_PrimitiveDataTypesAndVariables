using System;

class NullValuesArithmetic
{
    static void Main()
    {
        Console.Title = "Null values arithmetic";
        int? i = null;
        double? d = null;
        Console.WriteLine("i={0}\t[null values]", i);
        Console.WriteLine("d={0}\t[null values]", d);
        i = i.GetValueOrDefault() + 5;
        d = d.GetValueOrDefault() + 3.33;
        Console.WriteLine("i={0}\t[null + 5]", i);
        Console.WriteLine("d={0}\t[null + 3.33]", d);
    }
}
