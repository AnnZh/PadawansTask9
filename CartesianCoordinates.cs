using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            if (points == null) throw new ArgumentNullException();
            if (points.Length < 1) throw new ArgumentException();
            if (range < 1) throw new ArgumentException();

            List<Point> list = new List<Point>();
            foreach (Point value in points)
            {
                if ((Math.Abs(point.X - value.X) <= range) && (Math.Abs(point.Y - value.Y) <= range))
                {
                    list.Add(value);
                }
            }
            return list;
        }
    }
}