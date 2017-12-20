namespace MelrahShake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var key = Console.ReadLine();

            while (true)
            {
                var firstIndex = input.IndexOf(key);
                var lastIndex = input.LastIndexOf(key);
                if (firstIndex >=0 && lastIndex >=0 && firstIndex !=lastIndex && key != string.Empty)
                {
                    input = input.Remove(lastIndex, key.Length);
                    input = input.Remove(firstIndex, key.Length);
                    Console.WriteLine("Shaked it.");
                    key = key.Remove(key.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }    
            }
        }
    }
}
