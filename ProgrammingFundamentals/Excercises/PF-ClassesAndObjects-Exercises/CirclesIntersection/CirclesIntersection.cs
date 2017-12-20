namespace CirclesIntersection
{
    using System;
    using System.Linq;

    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstCircleCoordinates = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var firstCircleCenter = new Point
            {
                X = firstCircleCoordinates[0],
                Y = firstCircleCoordinates[1]
            };
            var firstCircle = new Circle
            {
                Radius = firstCircleCoordinates[2],
                Center = firstCircleCenter
            };

            var secondCircleCoordinates = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToArray();
            var secondCircleCenter = new Point
            {
                X = secondCircleCoordinates[0],
                Y = secondCircleCoordinates[1]
            };
            var secondCircle = new Circle
            {
                Radius = secondCircleCoordinates[2],
                Center = secondCircleCenter
            };
            if (Circle.Intersection(firstCircle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }

    }
}
