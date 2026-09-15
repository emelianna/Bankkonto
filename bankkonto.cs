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

    while (!isValid || number == 0) //För att säkra att svaret inte är 0 eller annat än ett nummer
    {
        if (!isValid)
        {
            Console.Write("Det där var inget heltal. Vänligen ange ett heltal: ");
        }
        else
        {
            Console.Write("Du har angett 0. Vänligen ange ett heltal: ");
        }
 
        input = Console.ReadLine();                        
        isValid = int.TryParse(input, out number);          
}
        return number;
    
}






public void Deposit(string prompt)               //Metod för att sätta in pengar.  
{                                                 //Behöver hindra från att sätta in negativt belopp  
  double deposit = Amount("Hur mycket vill du sätta in? ");                                 //Hindra om kontot är spärrat
  double depositTo = 
  
  
  MoneyInAccount.Add(deposit);                                            
                                                  //Överföringar mellan dessa tre konton??
                                                  //Hindra från att frånkonto och -tillkonto är samma
}

public void Withdraw(double amount)               //Metod för att ta ut pengar. Behöver hindra att ta ut om det är tomt, 
                                                  //såvida det inte är tillåtet
                                                  //Behöver också hindra att ta ut om det är spärrat
{
   amount = 1000; 
}







public override string ToString() //Gör ett objekt utskrivbart genom att skriva över en metod som redan finns
                                      //När Console.WriteLine(kemi); körs visas detta nedan gällande kursen kemi   
    {
        return $"Konotummer:{AccountNumber} Kontonamn:{AccountName} kontotyp:{AccountType} Saldo:{Balance} Ränta:{Interest} Kreditgräns: {CreditLimit})";
    }
}

//Console.ReadLine för att inhämta summor att sätta in/föra över? 




