namespace Wheather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Wheather
    {
        public class WeatherInfo
        {
            public decimal Temperature { get; set; }

            public string Weather { get; set; }
        }
        public static void Main()
        {
            var pattern = @"(?<town>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-Za-z]+)\|";
            var weatherInfoDict = new Dictionary<string, WeatherInfo>();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var regex = new Regex(pattern);
                if (regex.IsMatch(line))
                {
                    var match = regex.Match(line);
                    var town = match.Groups["town"].Value;
                    var temperature = decimal.Parse(match.Groups["temp"].Value);
                    var weather = match.Groups["weather"].Value;
                    var weatherInfo = new WeatherInfo
                    {
                        Temperature = temperature,
                        Weather = weather
                    };

                    weatherInfoDict[town] = weatherInfo;
                }
                line = Console.ReadLine();
            }
            var sortedWeatherInfo = weatherInfoDict.OrderBy(x => x.Value.Temperature).ToDictionary(x => x.Key, x => x.Value);
           
            foreach (var kpv in sortedWeatherInfo)
            {
                    Console.WriteLine($"{kpv.Key} => {kpv.Value.Temperature:F2} => {kpv.Value.Weather}");
            }
        }
    }
}
