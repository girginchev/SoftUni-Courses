namespace PunctuationFinder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class PunctuationFinder
    {
        public static void Main()
        {
            var text = File.ReadAllText("sample_text.txt");
            var separators = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    separators.Add(text[i]);
                }
                else if (text[i] == ',')
                {
                    separators.Add(text[i]);
                }
                else if (text[i] == '!' )
                {
                    separators.Add(text[i]);
                }
                else if (text[i] == '?')
                {
                    separators.Add(text[i]);
                }
                else if (text[i] == ':') 
                {
                    separators.Add(text[i]);
                }
            }
            Console.WriteLine(string.Join(", ",separators));
        }
    }
}
