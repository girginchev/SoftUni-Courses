namespace SearchForANumber
{
    using System;
    using System.Linq;
    public class SearchForANumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var elementsInformation = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var numberOfElementsToTake = elementsInformation[0];
            var numberOfElementsToDelete = elementsInformation[1];
            var searchedNumber = elementsInformation[2];

            numbers.Take(numberOfElementsToTake);
            numbers.RemoveRange(0, numberOfElementsToDelete);
            if (numbers.Contains(searchedNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
