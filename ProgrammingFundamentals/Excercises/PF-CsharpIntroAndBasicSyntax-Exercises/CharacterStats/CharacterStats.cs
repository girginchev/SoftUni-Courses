namespace CharacterStats
{
    using System;
    class CharacterStats
    {
        static void Main()
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHelath = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            Console.Write("Health: ");
            Console.Write("|");
            Console.Write(new string('|',health));
            Console.Write(new string('.',maxHelath - health));
            Console.WriteLine("|");

            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new string('|', energy));
            Console.Write(new string('.', maxEnergy - energy));
            Console.WriteLine("|");
        }
    }
}
