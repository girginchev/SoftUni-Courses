
namespace HouseBuilder
{
    using System;

    public class HouseBuilder
    {
        public static void Main()
        {
            var totalPrice = 0l;
            for (int i = 0; i < 2; i++)
            {
                var price = long.Parse(Console.ReadLine());
                if (price <= sbyte.MaxValue)
                {
                    totalPrice += price * 4;
                }
                else
                {
                    totalPrice += price * 10;
                }
            }
            Console.WriteLine(totalPrice);

        }
    }
}
