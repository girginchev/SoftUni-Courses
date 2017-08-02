using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var commands = Console.ReadLine();
            var usersLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (commands != "end")
            {
                var line = commands.Split(new char[] {' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                var name = line[5];
                var ip = line[1];
                var counter = 1;
                if (!usersLogs.ContainsKey(name))
                {
                    usersLogs[name] = new Dictionary<string, int>();
                }
                if (!usersLogs[name].ContainsKey(ip))
                {
                    usersLogs[name][ip] = counter;
                }
                else
                {
                    usersLogs[name][ip]++;
                }
                commands = Console.ReadLine();
            }
            foreach (var user in usersLogs)
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
