using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Game
{
    public  class Element
    {
        private static List<Point> coordinates = new List<Point>();

        public static List<Point> getCoordinates()
        {
            return coordinates;
        }

        public static void setInitialCoordinates(int index, Point point)
        {
            coordinates.Insert(index, point);
        }

        public static void setCoordinates(int index, Point point)
        {          
            coordinates[index] = point;
        }

    }
}
