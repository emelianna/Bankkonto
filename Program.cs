using System.Globalization;

Bankkonto salaryAccount = new("1234567890","Sven Svensson", "Lönekonto", 30000, 0, 0, false); 

Bankkonto saveAccount = new("2234567891","Sven Svensson", "Sparkonto", 3000000, 0.02, 0, false); 

Bankkonto creditAccount = new("3234567880","Sven Svensson", "Kreditkonto", 300, -0.07, -100000, false); 

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
            Console.WriteLine("Det där var inget heltal. Ange 1, 2, eller 3: ");
        }
        else
        {
            Console.WriteLine("Ange 1, 2, eller 3:  ");
        }

        input = Console.ReadLine();
        isValid = int.TryParse(input, out number);
    }

    int index = number - 1;
    return index;
}
bool quit = false;
string statusMessage = "";

while (!quit)               //Meny för att välja mellan att lägga till, ta bort eller avsluta.
{                           //Loop som fortsätter tills användaren anger 3 (avsluta). 
  
    Console.WriteLine();
    Console.WriteLine("***** MENY *****");
    Console.WriteLine("1. Sätta in pengar");
    Console.WriteLine("2. Ta ut pengar");
    Console.WriteLine("3. Göra en överföring");
    Console.WriteLine("4. Se saldo");
    Console.WriteLine("5. Avsluta");


     if (statusMessage != "")                  //Vid case 5 används inte denna 
        {
            Console.WriteLine();
            Console.WriteLine(statusMessage); //Skriver ut meddelandet i case 1 eller 2
            statusMessage = "";                 //Nollställer sedan till nästa runda 
        }

    
    Console.WriteLine();
    Console.WriteLine("Vad vill du göra? ");
    

    string? choice = Console.ReadLine(); //Svaret på menyvalen. Genererar rätt case nedan som använder 
                                         //rätt metod och skriver ut rätt statusmeddelande    
    switch (choice)
    {
        case "1":
           { int index = ChosenAccount("Till vilket konto vill du sätta in pengar? 1 för lönekonto, 2 för sparkonto, 3 för kreditkonto ");
            Bankkonto chosenAccount = BankAccounts[index];   

            double deposited = chosenAccount.Deposit("Hur mycket vill du sätta in? ");
            statusMessage = $"{deposited} kr är insatt på {chosenAccount.AccountType}.";    
            break;
}

        case "2":
            {int index = ChosenAccount("Från vilket konto vill du ta ut pengar? 1 för lönekonto, 2 för sparkonto, 3 för kreditkonto ");
            Bankkonto chosenAccount = BankAccounts[index];   

            double withdrawn = chosenAccount.Withdraw("Hur mycket vill du ta ut? ");
            
            
            statusMessage = $"Du har tagit ut {withdrawn}kr. ";
            break;
            }
            case "3":

            //statusMessage = ($"Du har fört över {}kr. ");
            {
            
            break;
}
            case "4":
{
             int index = ChosenAccount("Vilket konto vill du se saldo för? 1 för lönekonto, 2 för sparkonto, 3 för kreditkonto ");
            Bankkonto chosenAccount = BankAccounts[index];
            statusMessage = $"Ditt saldo är {chosenAccount.Balance}kr. ";
            break;
}
        case "5":
            quit = true;
            Console.WriteLine("Hej då!");
            break;

        default:
            Console.WriteLine("Det där var inget giltigt val, försök igen.");
            break;
    }
}


