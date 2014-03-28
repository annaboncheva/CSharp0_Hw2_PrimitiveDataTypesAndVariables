using System;

class ExchangeVarValues
{
    static void Main()
    {
        Console.Title = "Exchange Variable Values";
        int a = 5;
        int b = 10;
        Console.WriteLine("a={0}\nb={1}", a, b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("new a={0}\nnew b={1}", a, b);
    }
}
