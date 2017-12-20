namespace LongerLine
{
    using System;
    public class LongerLine
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var firstLineLenght = FirstLineLenght(x1, y1, x2, y2);
            var secondLineLenght = SecondLineLenght(x3, y3, x4, y4);

            if (secondLineLenght > firstLineLenght)
            {
                var firstNearestPointSecLine = GetDistanceToCenterSecLine(x3, y3, 0, 0);
                var secNearestPointSecLine = GetDistanceToCenterSecLine(0, 0, x4, y4);
                if (firstNearestPointSecLine > secNearestPointSecLine)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
            }
            else
            {
                var firstNearestPointFirstLine = GetDistanceToCenterFirstLine(x1, y1, 0, 0);
                var secNearestPointFirstLine = GetDistanceToCenterFirstLine(0, 0, x2, y2);
                if (firstNearestPointFirstLine > secNearestPointFirstLine)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
            }
        }
        public static double GetDistanceToCenterFirstLine(double x1, double y1, double x2, double y2)
        {
            var pointDistance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return pointDistance;
        }
        public static double GetDistanceToCenterSecLine(double x3, double y3, double x4, double y4)
        {
            var pointDistance = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            return pointDistance;
        }
        public static double FirstLineLenght(double x1, double y1, double x2, double y2)
        {
            var lineLenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lineLenght;
        }
        public static double SecondLineLenght(double x3, double y3, double x4, double y4)
        {
            var lineLenght = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            return lineLenght;
        }
    }
}
