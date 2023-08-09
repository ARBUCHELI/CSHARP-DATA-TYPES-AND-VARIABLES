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
      Console.WriteLine($"{numeric_money} cents is equal to...\n");
      int goldValue = 10;
      int silverValue = 5;
      double goldCoins = Math.Floor(numeric_money /   goldValue);
      double remainder = numeric_money % goldValue;
      double silverCoins = Math.Floor(remainder /  silverValue);
      remainder = remainder % silverValue;
      Console.WriteLine($"Gold coins: {goldCoins}\n");
      Console.WriteLine($"Silver coins: {silverCoins}\n");
      Console.WriteLine($"Bronze coins: {remainder}\n");
    }
  }
}
