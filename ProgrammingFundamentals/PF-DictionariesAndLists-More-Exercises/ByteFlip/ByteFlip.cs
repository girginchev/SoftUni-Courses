namespace ByteFlip
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ByteFlip
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split().Where(e => e.Length == 2).Select(e => new string(e.Reverse().ToArray())).Reverse().ToList();
            var result = new List<char>();
            foreach (var item in entry)
            {
                var letter = (char)Convert.ToInt32(item,16);
                result.Add(letter);
            }
            foreach (var letter in result)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}
