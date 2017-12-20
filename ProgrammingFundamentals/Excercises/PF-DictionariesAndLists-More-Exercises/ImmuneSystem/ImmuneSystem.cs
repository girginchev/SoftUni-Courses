namespace ImmuneSystem
{
    using System;
    using System.Collections.Generic;

    public class ImmuneSystem
    {
        public static void Main(string[] args)
        {
            var initialHealth = int.Parse(Console.ReadLine());
            var firstHealth = initialHealth;
            var virus = Console.ReadLine();
            var virusesPassed = new List<string>();
            while (virus != "end")
            {
                var virusStrenght = 0;
                var timeToDefeatInSeconds = 0;
                foreach (var letter in virus)
                {
                    virusStrenght += (int)letter;
                }
                virusStrenght /= 3;
                if (!virusesPassed.Contains(virus))
                {
                    virusesPassed.Add(virus);
                    timeToDefeatInSeconds = virusStrenght * virus.Length;
                }
                else
                {
                    timeToDefeatInSeconds = virusStrenght * virus.Length / 3;
                }
                initialHealth -= timeToDefeatInSeconds;
                if (initialHealth > 0)
                {
                    Console.WriteLine($"Virus {virus}: {virusStrenght} => {timeToDefeatInSeconds} seconds");
                    var timeToDefeat = new TimeSpan(0, 0, timeToDefeatInSeconds);
                    Console.WriteLine("{0} defeated in {1}m {2}s.",virus,timeToDefeat.Minutes,timeToDefeat.Seconds);
                    Console.WriteLine($"Remaining health: {initialHealth}"); 
                    initialHealth = (int)(initialHealth * 1.2);
                    if (initialHealth > firstHealth)
                    {
                        initialHealth = firstHealth;
                    }
                }
                else
                {
                    Console.WriteLine($"Virus {virus}: {virusStrenght} => {timeToDefeatInSeconds} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                virus = Console.ReadLine();
            }
            Console.WriteLine("Final Health: {0}",initialHealth);

        }
    }
}
