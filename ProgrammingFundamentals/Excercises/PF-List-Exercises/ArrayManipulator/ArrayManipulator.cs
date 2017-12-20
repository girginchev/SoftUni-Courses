namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var commandInfo = Console.ReadLine()
                .Split()
                .ToList();

            while (commandInfo[0] != "print")
            {
                var command = commandInfo[0];
                switch (command)
                {
                    case "add":
                        AddElementInArr(arr, commandInfo);
                        break;

                    case "addMany":
                        AddManyElementsInArr(arr, commandInfo);
                        break;

                    case "contains":
                        PrintElementIfContains(arr, commandInfo);
                        break;
                    case "remove":
                        RemoveAtIndexInArr(arr, commandInfo);
                        break;
                    case "shift":
                        RotateArr(arr, commandInfo);
                        break;
                    case "sumPairs":
                        arr = SumPairsInArr(arr);
                        break;
                }

                commandInfo = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"[{string.Join(", ",arr)}]");
        }

        public static List<int> SumPairsInArr(List<int> arr)
        {
            var result = new List<int>();
            for (int i = 0; i < arr.Count; i += 2)
            {
                if (i < arr.Count - 1)
                {
                    result.Add(arr[i] + arr[i + 1]);
                }
                else
                {
                    result.Add(arr[i]);
                }
            }
            arr.Clear();
            arr = result;
            return arr;
        }

        public static void RotateArr(List<int> arr, List<string> commandInfo)
        {
            var possitionShift = int.Parse(commandInfo[1]);
            for (int i = 0; i < possitionShift % arr.Count; i++)
            {
                var temp = arr[0];
                for (int j = 0; j < arr.Count - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Count - 1] = temp;
            }
        }

        public static void RemoveAtIndexInArr(List<int> arr, List<string> commandInfo)
        {
            var indexRemove = int.Parse(commandInfo[1]);
            arr.RemoveAt(indexRemove);
        }

        public static void PrintElementIfContains(List<int> arr, List<string> commandInfo)
        {
            var elementContains = int.Parse(commandInfo[1]);
            if (arr.Contains(elementContains))
            {
                Console.WriteLine(arr.IndexOf(elementContains));
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        public static void AddManyElementsInArr(List<int> arr, List<string> commandInfo)
        {
            var indexAddMany = int.Parse(commandInfo[1]);
            var elementsToAdd = new List<int>();
            for (int i = 2; i < commandInfo.Count; i++)
            {
                elementsToAdd.Add(int.Parse(commandInfo[i]));
            }
            arr.InsertRange(indexAddMany, elementsToAdd);
        }

        public static void AddElementInArr(List<int> arr, List<string> commandInfo)
        {
            var indexAdd = int.Parse(commandInfo[1]);
            var element = int.Parse(commandInfo[2]);
            arr.Insert(indexAdd, element);
        }
    }
}
