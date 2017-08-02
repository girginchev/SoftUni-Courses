using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    public class Circle
    {
        public double Radius { get; set; }

        public Point Center { get; set; }


        public static bool Intersection(Circle firstCircle, Circle secondCircle)
        {
            var distance = Math.Sqrt(Math.Pow(secondCircle.Center.X - firstCircle.Center.X, 2) + Math.Pow(secondCircle.Center.Y - firstCircle.Center.Y, 2));
            if ( distance <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }
            return false;
        }
    }
}
