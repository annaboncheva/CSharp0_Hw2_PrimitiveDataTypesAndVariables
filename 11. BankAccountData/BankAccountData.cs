using System;

class BankAccountData
{
    static void Main()
    {
        Console.Title = "Bank Account Data";
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Middle Name: ");
        string middleName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Available amount of money: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Bank Name: ");
        string bankName = Console.ReadLine();
        Console.Write("IBAN: ");
        string iban = Console.ReadLine();
        Console.Write("1st Credit Card Number: ");
        ulong firstCard = ulong.Parse(Console.ReadLine());
        Console.Write("2nd Credit Card Number: ");
        ulong secondCard = ulong.Parse(Console.ReadLine());
        Console.Write("3rd Credit Card Number: ");
        ulong thirdCard = ulong.Parse(Console.ReadLine());
        Console.WriteLine("\nBank Account Data:\n{0} {1} {2}\n{3}", firstName, middleName, lastName, bankName);
        Console.WriteLine("IBAN {0}\n1st Credit Card {1}\n2nd Crdit Card {2}\n3rd Credit Card{3}", iban, firstCard, secondCard, thirdCard);
        Console.WriteLine("Balance {0}", balance);
    }
}

