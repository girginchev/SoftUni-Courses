namespace EmailStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class EmailStatistics
    {
        public static void Main()
        {
            var regex = new Regex(@"\b(?<user>[A-Za-z]{5,})\@(?<domain>([a-z]{3,})(\.com|\.bg|\.org))\b");
            var emailsBook = new Dictionary<string, List<string>>();

            var nEmails = int.Parse(Console.ReadLine());
            for (int i = 0; i < nEmails; i++)
            {
                var email = Console.ReadLine();
                if (regex.IsMatch(email))
                {
                    var user = regex.Match(email).Groups["user"].Value;
                    var domain = regex.Match(email).Groups["domain"].Value;
                    if (!emailsBook.ContainsKey(domain))
                    {
                        emailsBook[domain] = new List<string>();
                    }
                    if (!emailsBook[domain].Contains(user))
                    {
                        emailsBook[domain].Add(user);
                    }

                }
            }
            var sortedEmailsBook = emailsBook.OrderByDescending(e => e.Value.Count());
            foreach (var kpv in sortedEmailsBook)
            {
                Console.WriteLine($"{kpv.Key}:");
                foreach (var user in kpv.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }       
        }
    }
}
