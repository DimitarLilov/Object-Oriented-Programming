using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    class Point3D
    {
        private static readonly Point3D StartPoint = new Point3D(0, 0, 0);


        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartingPoint
        {
            get
            {
                return Point3D.StartPoint;
            }
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public override string ToString()
        {
            return string.Format("Point coordinates \nX: {0} \nY: {1} \nZ: {2}",X,Y,Z);
        }
    }
}
