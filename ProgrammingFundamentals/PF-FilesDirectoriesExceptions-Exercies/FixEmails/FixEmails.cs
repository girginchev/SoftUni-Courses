using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var lines = File.ReadAllLines(@"..\..\emails.txt");
            var emailBook = new Dictionary<string, string>();

            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (!emailBook.ContainsKey(lines[i]))
                    {
                        emailBook[lines[i]] = "";
                    }
                }
                else
                {
                    emailBook[lines[i - 1]] = lines[i];
                }
            }

            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (var email in emailBook)
            {
                if (!email.Value.ToLower().EndsWith("us") && !email.Value.ToLower().EndsWith("uk"))
                {
                    result.Add(email.Key, email.Value);
                }


            }
            foreach (var item in result)
            {
                File.AppendAllText(@"..\..\resutl.txt", $"{item.Key} - {item.Value}{Environment.NewLine}");
            }

        }
    }
}
