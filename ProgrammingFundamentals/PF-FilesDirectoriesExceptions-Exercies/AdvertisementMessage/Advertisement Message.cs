using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            var phrases = File.ReadAllLines(@"..\..\Phrases.txt");
            var authores = File.ReadAllLines(@"..\..\Author.txt");
            var events = File.ReadAllLines(@"..\..\Events.txt");
            var cities = File.ReadAllLines(@"..\..\Cities.txt");
            var random = new Random(5);


            int messagesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesNumber; i++)
            {
                var phraseRandom = phrases[random.Next(0, phrases.Length)];
                var authorRandom = authores[random.Next(0, authores.Length)];
                var eventRandom = events[random.Next(0, events.Length)];
                var cityRandom = cities[random.Next(0, cities.Length)];
                var message = string.Format("{0} {1} {2} - {3}{4}", phraseRandom, eventRandom, authorRandom, cityRandom, Environment.NewLine);
                File.AppendAllText(@"../../generatedMessage.txt", message );
            }
        }
    }
}
