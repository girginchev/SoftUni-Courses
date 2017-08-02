namespace BackIn30Minutes
{
    using System;
    using System.Globalization;
    class BackIn30Minutes
    {
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var time = string.Format($"{hour}:{minute}");

            DateTime result = DateTime.ParseExact(time,"H:m",CultureInfo.InvariantCulture);
            Console.WriteLine($"{result.AddMinutes(30):H:mm}");
        }
    }
}
