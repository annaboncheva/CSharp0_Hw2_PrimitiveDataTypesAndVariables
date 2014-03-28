using System;
using System.Text;

class PrintASCII
{
    static void Main()
    {
        Console.Title = "Print ASCII"; 
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}\t{1}", i, symbol);
        }
    }
}
