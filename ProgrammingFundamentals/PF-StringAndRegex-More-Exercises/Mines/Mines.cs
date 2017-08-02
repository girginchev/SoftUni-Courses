namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class Mines
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var mine = new Regex(@"<(.{2})>");
            var mines = mine.Matches(line);
            foreach (Match m in mines)
            {
                var firstChar = m.Groups[1].Value[0];
                var secChar = m.Groups[1].Value[1];
                var power = Math.Abs(firstChar - secChar);
                var index = m.Index;
                var bombStartIndex = Math.Max(0, index - power);
                var bombRightIndex = Math.Min(index + power + 4, line.Length);
                var bombCount = bombRightIndex - bombStartIndex;
                var bomb = line.Substring(bombStartIndex, bombCount);
                line = line.Replace(bomb, new string('_', bomb.Length));
            }
            Console.WriteLine(line);
        }
    }
}
