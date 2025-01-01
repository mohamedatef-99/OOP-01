using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    internal struct PointAssignment
    {
        public double X
        {
            get; set;
        }


        public double Y
        {
            get; set;
        }
        public static double CalculateDistance(PointAssignment p1, PointAssignment p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
