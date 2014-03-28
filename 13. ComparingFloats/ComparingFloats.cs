using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Title = "Comparing floats";
        Console.Write("Submit a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Submit b=");
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double compare = a - b;
        bool equality = compare < eps; // True
        Console.WriteLine("a is equal to b [with precision 0.000001]: {0}", equality);
    }
}


