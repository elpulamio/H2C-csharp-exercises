using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!

        Account mikesAccount = new Account("Mike's account", 100.0);
        mikesAccount.Deposit(20.0);
        Console.WriteLine(mikesAccount.balance);
        
    }
  }
}



