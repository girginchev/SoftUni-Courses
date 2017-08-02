namespace KarateString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class KarateString
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(">".ToArray(),StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();
            var remainingPower = 0;
            foreach (var kick in input)
            {
                if (kick[0] == '0' || kick[0] =='1' || kick[0] == '2' || kick[0] == '3' || kick[0] == '4' || kick[0] == '5'
                    || kick[0] == '6' || kick[0] == '7' || kick[0] == '8' || kick[0] == '9')
                {
                    var power = int.Parse(kick[0].ToString()) + remainingPower;
                    if (power <= kick.Length)
                    {
                        result.Add(kick.Remove(0, power));
                    }
                    else if (power == 0)
                    {
                        result.Add(kick);
                    }
                    else
                    {
                        result.Add("");
                        remainingPower = power - kick.Length;
                    }
                }
                else
                {
                    result.Add(kick.Remove(0, remainingPower));
                }
            }
            Console.WriteLine(string.Join(">",result));
        }
    }
}
