using _01.Point3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Distance_Calculator
{
    public static class DistanceCalculator
    {
        public static double Calculate3DPointDistance(Point3D point1, Point3D point2)
        {
            double xd = point2.X - point1.X;
            double yd = point2.Y - point1.Y;
            double zd = point2.Z - point1.Z;

            double distance = Math.Sqrt(Math.Pow(xd, 2) + Math.Pow(yd, 2) + Math.Pow(zd, 2));

            return double.Parse(String.Format("{0:F4}", distance));
        }
    }
}
