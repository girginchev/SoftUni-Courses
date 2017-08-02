namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string userName = input[1];
                var ip = input[0];
                var duration = int.Parse(input[2]);
                if (!logs.ContainsKey(userName))
                {
                    logs[userName] = new SortedDictionary<string, int>();
                }
                if (!logs[userName].ContainsKey(ip))
                {
                    logs[userName][ip] = 0;
                }
                logs[userName][ip] += duration;
            }
            foreach (var log in logs)
            {
                var name = log.Key;
                var ip = log.Value.Keys;
                var time = log.Value.Values.Sum();
                Console.WriteLine($"{name}: {time} [{string.Join(", ", ip)}]");
            }
        }
    }
}
