namespace GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            var figureType = Console.ReadLine().ToLower();

            switch (figureType)
            {
                case "triangle":
                    var sideTriangle = double.Parse(Console.ReadLine());
                    var heightTriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}",GetTriangleArea(sideTriangle, heightTriangle));
                    break;
                case "square":
                    var sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", GetSquareArea(sideSquare));
                    break;
                case "rectangle":
                    var widthRectangel = double.Parse(Console.ReadLine());
                    var heightRectangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", GetRectangleArea(widthRectangel, heightRectangle));
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", GetCircleArea(radius));
                    break;
                default:
                    break;
            }
        }

        public static double GetCircleArea(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public static double GetRectangleArea(double widthRectangel, double heightRectangle)
        {
            var area = widthRectangel * heightRectangle;
            return area;
        }

        public static double GetSquareArea(double sideSquare)
        {
            var area = Math.Pow(sideSquare, 2);
            return area;
        }

        public static double GetTriangleArea(double sideTriangle, double heightTriangle)
        {
            var area = (sideTriangle * heightTriangle) / 2;
            return area;
        }
    }
}

