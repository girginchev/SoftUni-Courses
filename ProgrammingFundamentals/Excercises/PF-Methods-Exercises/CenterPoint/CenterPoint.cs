namespace CenterPoint
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            GetNearestPoitToCenter(x1, y1, x2, y2);
        }

        public static double GetDistanceFirstPoint(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
        public static double GetDistanceSecondPoint(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
        public static void GetNearestPoitToCenter(double x1, double y1, double x2, double y2)
        {
            var firstPointDistance = GetDistanceFirstPoint(x1, y1, 0, 0);
            var secondPointDistance = GetDistanceSecondPoint(0, 0, x2, y2);
            if (firstPointDistance > secondPointDistance)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }
    }
}
