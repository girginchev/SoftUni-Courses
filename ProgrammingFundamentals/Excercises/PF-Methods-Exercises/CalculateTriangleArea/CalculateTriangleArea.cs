﻿namespace CalculateTriangleArea
{
    using System;
    
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(width, height);
            Console.WriteLine(area);
        }

        public static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
