using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    public class AMinerTask
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("file.txt");
            var result = new Dictionary<string, double>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "stop")
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    if (!result.ContainsKey(lines[i]))
                    {
                        result[lines[i]] = 0;
                    }
                }
                else
                {
                    var count = double.Parse(lines[i]);
                        result[lines[i-1]] += count;
                }

            }
            foreach (var item in result)
            {
                File.AppendAllText("result.txt",string.Format("{0} -> {1}{2}", item.Key,item.Value, Environment.NewLine));
            }
        }
    }
}
