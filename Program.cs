using System.Globalization;

Bankkonto salaryAccount = new("1234567890","Sven Svensson", "Salary Account", 30000, 0, 0, true); 

Bankkonto saveAccount = new("2234567891","Sven Svensson", "Save Account", 3000000, 0.02, 0, true); 

Bankkonto creditAccount = new("3234567880","Sven Svensson", "Credit Account", 300, -0.07, -100000, true); 

List<Bankkonto> BankAccounts = [salaryAccount, saveAccount, creditAccount];




static int ChosedAccount(string prompt)
{
    Console.WriteLine(prompt);
    string? input = Console.ReadLine();
    bool isValid = int.TryParse(input, out int number);

    while (!isValid || number < 1 || number > 3)
    {
        if (!isValid)
        {
            Console.WriteLine("Det där var inget heltal. Ange 1, 2 eller 3: ");
        }
        else
        {
            Console.WriteLine("Ange 1, 2 eller 3: ");
        }

        input = Console.ReadLine();
        isValid = int.TryParse(input, out number);
    }

    int index = number - 1;
    return index;
}

