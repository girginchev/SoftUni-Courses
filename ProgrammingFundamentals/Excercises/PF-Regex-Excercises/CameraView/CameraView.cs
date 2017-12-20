namespace CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CameraView
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var skipElement = elements[0];
            var takeElements = elements[1];

            var result = new List<string>();

            var text = Console.ReadLine().Trim().Split(new char[] { '|' },StringSplitOptions.RemoveEmptyEntries);
            foreach (var entry in text)
            {
                if (entry.StartsWith("<"))
                {
                    if (skipElement >=0 && takeElements >=0)
                    {
                        result.Add(new string(entry.Skip((skipElement + 1)).Take(takeElements).ToArray()));
                    }
                }
            }
            var finalResult = result.Where(e => e != string.Empty).ToArray();
            if (finalResult.Length>0)
            {
                Console.WriteLine(string.Join(", ", finalResult));
            }
        }
    }
}
