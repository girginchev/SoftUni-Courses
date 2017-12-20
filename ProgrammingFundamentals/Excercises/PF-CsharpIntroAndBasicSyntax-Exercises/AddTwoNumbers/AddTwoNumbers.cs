namespace AddTwoNumbers
{
    using System;
    class AddTwoNumbers
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            var sum = firstNum + secNum;

            Console.WriteLine($"{firstNum} + {secNum} = {sum}");
        }
    }
}
