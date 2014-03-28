using System;

class EmployeeData
{
    static void Main()
    {
        Console.Title = "Employee Data";
        Console.Write("Employee First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Employee Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Employee Age (0...100): ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Employee Gender (m or f): ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Employee Personal ID Number (e.g. 8306112507): ");
        ulong idNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Unique Employee Number (27560000...27569999): ");
        uint emplNumber = uint.Parse(Console.ReadLine());
        string gend;
        if (gender == 'm')
        {
            gend = "male";
        }
        else
        {
            gend = "female";
        }
        Console.WriteLine("\nEmployee Number {0}:\n{1} {2}\n{3} years\n{4}\nPersonal ID {5}", emplNumber, firstName, lastName, age, gend, idNumber);

    }
}
