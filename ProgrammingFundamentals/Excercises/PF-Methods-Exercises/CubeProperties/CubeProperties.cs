namespace CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            var cubeSide = double.Parse(Console.ReadLine());
            var property = Console.ReadLine();

            var faceDiagonal = FaceDiagonal(cubeSide);
            var spaceDiagonal = SpaceDiagonal(cubeSide);
            var volume = VolumeCube(cubeSide);
            var area = AreaCube(cubeSide);

            switch (property)
            {
                case "face": Console.WriteLine("{0:f2}",faceDiagonal); break;
                case "space": Console.WriteLine("{0:f2}",spaceDiagonal); break;
                case "volume": Console.WriteLine("{0:f2}",volume); break;
                case "area": Console.WriteLine("{0:f2}",area); break;
                default:
                    break;
            }
        }

        public static double FaceDiagonal(double cubeSide)
        {
            var faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            return faceDiagonal;
        }
        public static double SpaceDiagonal(double cubeSide)
        {
            var spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            return spaceDiagonal;
        }
        public static double VolumeCube(double cubeSide)
        {
            var volume = Math.Pow(cubeSide, 3);
            return volume;
        }
        public static double AreaCube(double cubeSide)
        {
            var area = 6 * Math.Pow(cubeSide, 2);
            return area;
        }
    }
}
