namespace DebitCardNumber
{
    using System;
    class DebitCardNumber
    {
        static void Main()
        {
            var firstFour = int.Parse(Console.ReadLine());
            var secFour = int.Parse(Console.ReadLine());
            var thirdFour = int.Parse(Console.ReadLine());
            var fourthFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstFour:D4} {secFour:D4} {thirdFour:D4} {fourthFour:D4}");
        }
    }
}
