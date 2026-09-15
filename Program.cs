using System.Globalization;

Bankkonto salaryAccount = new("1234567890","Sven Svensson", "Salary Account", 30000, 0, 0, false); 

Bankkonto saveAccount = new("2234567891","Sven Svensson", "Save Account", 3000000, 0.02, 0, false); 

Bankkonto creditAccount = new("3234567880","Sven Svensson", "Credit Account", 300, -0.07, -100000, false); 

List<Bankkonto> BankAccounts = [salaryAccount, saveAccount, creditAccount];




static int ChosenAccount(string prompt)
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

//Ska göra meny för val 
//switch (choice)

/*int index = ChosenAccount("Till vilket konto vill du sätta in pengar? 1 för lönekonto, 2 för sparkonto, 3 för kreditkonto ");
Bankkonto chosenAccount = BankAccounts[index];   

chosenAccount.Deposit("Hur mycket vill du sätta in? ");  */

/*int index = ChosenAccount("Från vilket konto vill du ta ut pengar? 1 för lönekonto, 2 för sparkonto, 3 för kreditkonto ");
Bankkonto chosenAccount = BankAccounts[index];   

chosenAccount.Withdraw("Hur mycket vill du ta ut? "); */

