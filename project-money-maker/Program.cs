using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.Write("Enter money to convert to coins: ");
      string money = Console.ReadLine();
      double numeric_money = Convert.ToDouble(money);
      Console.WriteLine($"{numeric_money} cents is equal to...");
    }
  }
}
