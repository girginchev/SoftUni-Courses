namespace BoatSimulator
{
    using System;
    public class BoatSimulator
    {
        public static void Main()
        {
            var fistBoatSymbol = char.Parse(Console.ReadLine());
            var secBoatSymbol = char.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var firsBoatDistance = 0;
            var secBoatDistance = 0;

            for (int i = 1; i <= n; i++)
            {
                var move = Console.ReadLine();
                if (move == "UPGRADE")
                {
                    fistBoatSymbol = (char)(fistBoatSymbol + 3);
                    secBoatSymbol = (char)(secBoatSymbol + 3);
                }
                else
                {
                    if (i % 2 !=0)
                    {
                        firsBoatDistance += move.Length;
                    }
                    else
                    {
                        secBoatDistance += move.Length;
                    }
                }
                if (firsBoatDistance >= 50 || secBoatDistance >= 50)
                {
                    break;
                }
            }
            if (firsBoatDistance > secBoatDistance)
            {
                Console.WriteLine(fistBoatSymbol);
            }
            else
            {
                Console.WriteLine(secBoatSymbol);
            }
        }
    }
}
