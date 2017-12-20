namespace ConvertSpeedUnits
{
    using System;
    class ConvertSpeedUnits
    {
        static void Main()
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = seconds + minutes * 60 + hours * 60 * 60;

            float metersPerSecond = (float)distanceMeters / totalSeconds;
            float kilometersPerhour = (distanceMeters/ 1000.0F) / (totalSeconds / 3600.0F);
            float milesPerHour = (distanceMeters / 1609.0F) / (totalSeconds / 3600.0F);

            Console.WriteLine("{0}",metersPerSecond);
            Console.WriteLine("{0}", kilometersPerhour);
            Console.WriteLine("{0}", milesPerHour);

        }
    }
}
