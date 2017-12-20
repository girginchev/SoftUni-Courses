namespace SumReversedNumbers
{
    using System;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;
            foreach (var number in numbers)
            {
                string newNum = "0";
                var temp = number;
                for (int i = temp; i > 0;)
                {
                    newNum += (temp % 10);
                    temp /= 10;
                    i = temp;
                }
                var newN = int.Parse(newNum);
                sum += newN;
            }
            Console.WriteLine(string.Join(" ", sum));   
        }
    }
}
