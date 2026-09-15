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


public void Deposit(double deposit)               //Metod för att sätta in pengar.  
{                                                 //Behöver hindra från att sätta in negativt belopp  
  deposit = 1000;                                 //Hindra om kontot är spärrat
                                                  //Ska insättningarna ske mellan dessa tre konton??
                                                  //Hindra från att frånkonto och -tillkonto är samma
}

public void Withdraw(double amount)               //Metod för att ta ut pengar. Behöver hindra att ta ut om det är tomt, 
                                                  //såvida det inte är tillåtet
                                                  //Behöver också hindra att ta ut om det är spärrat
{
   amount = 1000; 
}

}

//Console.ReadLine för att inhämta summor att sätta in/föra över? 




