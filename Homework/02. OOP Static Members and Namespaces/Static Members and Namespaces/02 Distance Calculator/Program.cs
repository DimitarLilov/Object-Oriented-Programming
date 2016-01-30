using System;
using _01.Point3D;
using System.Linq;

namespace _02_Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the cordinates of your fist point separated by a space: ");
            int[] pointA =
                Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();

            Console.WriteLine("Enter the cordinates of your second point separated by a space: ");
            int[] pointB =
                Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();

            Point3D point1 = new Point3D(pointA[0], pointA[1], pointA[2]);
            Point3D point2 = new Point3D(pointB[0], pointB[1], pointB[2]);

            Console.WriteLine("The distance between your points is {0}", DistanceCalculator.Calculate3DPointDistance
                (point1, point2));

            
        }
    }
}
