class Bankkonto
(string accountNumber,                    //parameterlistan är konstruktorn
string accountName, string accountType, 
double balance, double interest, 
double creditLimit, bool blocked)
{
    string AccountNumber = accountNumber;     //fält som använder konstruktorn för att ge fälten sina startvärden
    string AccountName = accountName;         //de är inte public - ingen kod utanför klassen kan komma åt dem
    string AccountType = accountType;
    double Balance = balance;
    double Interest = interest;
    double CreditLimit = creditLimit;
    bool Blocked = blocked;

List<double> MoneyInAccount = [balance];

static double Amount(string prompt) //Metod för att fråga och ta emot summa. Ska användas tillsammans m Deposit och Withdrawl.
{                               
    Console.WriteLine(prompt);
    string? input = Console.ReadLine();
    bool isValid = int.TryParse(input, out int number);

    while (!isValid || number < 1 ) //För att säkra att svaret inte är 0 eller under, eller annat än ett nummer
    {
        if (!isValid)
        {
            Console.Write("Det där var inget heltal. Vänligen ange ett heltal: ");
        }
        else
        {
            Console.Write("Du har angett 0 eller negativt tal. Vänligen ange ett heltal: ");
        }
 
        input = Console.ReadLine();                        
        isValid = int.TryParse(input, out number);          
}
        return number;
    
}



public void Deposit(string prompt)               //Metod för att sätta in pengar.  
{           
  if (!Blocked)    
  {                                  
    double deposit = Amount(prompt);
    Balance += deposit;              
    MoneyInAccount.Add(deposit);
     }                                     
   else
    {
      Console.WriteLine("Ditt konto är spärrat!");
    }                                               
                                                  
}

public void Withdraw(string prompt)               //Metod för att ta ut pengar. Behöver hindra att ta ut om det är tomt, 
 {   
  if (!Blocked)
    {

    double withdrawl = Amount(prompt);                                                //såvida det inte är tillåtet
    Balance -= withdrawl;                                              
    MoneyInAccount.Add(-withdrawl);
  }
  else
    {
      Console.WriteLine("Ditt konto är spärrat!");
    }                                               
      
}

public void Transfer(string prompt)
  {
    
  }




public override string ToString() 
                                       
    {
        return $"Konotummer:{AccountNumber} Kontonamn:{AccountName} kontotyp:{AccountType} Saldo:{Balance} Ränta:{Interest} Kreditgräns: {CreditLimit})";
    }
}






