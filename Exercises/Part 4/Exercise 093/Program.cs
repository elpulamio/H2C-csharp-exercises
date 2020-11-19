using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!

        Account mikesAccount = new Account("Mike's account", 100);
        mikesAccount.Deposit(20);
        Console.WriteLine(mikesAccount.balance);
        
    }
  }
}



