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
            Console.WriteLine();
        }
    }
}
