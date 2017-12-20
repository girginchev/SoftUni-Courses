namespace TheatrePromotion
{
    using System;
    public class TheatrePromotion
    {
        public static void Main()
        {
            var dayType = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "Weekday":
                        ticketPrice = 12;
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        break;
                    case "Holiday":
                        ticketPrice = 5;
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (dayType)
                {
                    case "Weekday":
                        ticketPrice = 18;
                        break;
                    case "Weekend":
                        ticketPrice = 20;
                        break;
                    case "Holiday":
                        ticketPrice = 12;
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (dayType)
                {
                    case "Weekday":
                        ticketPrice = 12;
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        break;
                    case "Holiday":
                        ticketPrice = 10;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine($"{ticketPrice}$");
        }
    }
}
