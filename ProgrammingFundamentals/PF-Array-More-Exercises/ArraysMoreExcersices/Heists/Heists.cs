namespace Heists
{
    using System;
    using System.Linq;


    public class Heists
    {
        public static void Main()
        {
            var prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var jewelsPrice = prices[0];
            var goldPrice = prices[1];

            var totalMoneyEarned = 0;
            var totalExpenses = 0;

            var information = Console.ReadLine();
            while (information != "Jail Time")
            {
                var infoDetails = information.Split();
                var loot = infoDetails[0];
                foreach (var symbol in loot)
                {
                    if (symbol == '%')
                    {
                        totalMoneyEarned += jewelsPrice;
                    }
                    if (symbol == '$')
                    {
                        totalMoneyEarned += goldPrice;
                    }
                }
                var expense = int.Parse(infoDetails[1]);
                totalExpenses += expense;
                information = Console.ReadLine();
            }
            if (totalMoneyEarned >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalMoneyEarned - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalMoneyEarned}.");
            }
        }
    }
}
