class Bankkonto
(string accountNumber,                    //parameterlistan är konstruktorn
string accountName, string accountType, 
double balance, double interest, 
double creditLimit, bool blocked)
{
    string AccountNumber = accountNumber;     //fält som använder konstruktorn för att ge fälten sina startvärden
    public string AccountName { get; } = accountName;       //get för att de är private och program ska kunna komma åt
    public string AccountType { get; } = accountType;
    public double Balance { get; private set; } = balance;
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



public double Deposit(string prompt)               //Metod för att sätta in pengar.  
{           
  if (!Blocked)    
  {                                  
    double deposit = Amount(prompt);
    Balance += deposit;  
    MoneyInAccount.Add(deposit);

    return deposit;
     }                                     
  else
{
    Console.WriteLine("Ditt konto är spärrat!");
    return 0;
}                                             
                                                  
}

public double Withdraw(string prompt)               //Metod för att ta ut pengar. 
 {   
  if (!Blocked)
    {

   double withdrawl = Amount(prompt);

if (Balance - withdrawl < CreditLimit)
{
    Console.WriteLine("Du har inte tillräckligt med pengar för det uttaget.");
    return 0;
}
else
{
    Balance -= withdrawl;
    MoneyInAccount.Add(-withdrawl);
    return withdrawl;
}
    
  }

  else
    {
      Console.WriteLine("Ditt konto är spärrat!");
      return 0;
    }                                               
      
}

public void Transfer(string prompt) //Metod för att föra över mellan konton
  {
    
  }




public override string ToString() 
                                       
    {
        return $"Konotummer:{AccountNumber} Kontonamn:{AccountName} kontotyp:{AccountType} Saldo:{Balance} Ränta:{Interest} Kreditgräns: {CreditLimit})";
    }
}






