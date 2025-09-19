using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Snake.Game
{
    public class Mechanics
    {

        public static void createCoordinates(byte direction)
        {
            int tX = 0;
            int tY = 0;
            int tX2 = 0;
            int tY2 = 0;

            int x_aument = 0;
            int y_aument = 0;

            Point point = changeDirection(direction);
            x_aument = point.X;
            y_aument = point.Y;

            tX2 = Element.getCoordinates()[0].X;
            tY2 = Element.getCoordinates()[0].Y; 

            Element.getCoordinates()[0] = new Point(tX2 + x_aument, tY2 + y_aument);
            Control.x = Element.getCoordinates()[0].X;
            Control.y = Element.getCoordinates()[0].Y;

            int c = 1;
            while (c < Element.getCoordinates().Count)
            {
                if (c%2 == 0) 
                {
                    tX2 = Element.getCoordinates()[c].X;
                    tY2 = Element.getCoordinates()[c].Y;
                    Element.getCoordinates()[c] = new Point(tX, tY); 
                }
                else
                {
                    tX = Element.getCoordinates()[c].X;
                    tY = Element.getCoordinates()[c].Y;
                    Element.getCoordinates()[c] = new Point(tX2, tY2); 
                }

                c++;    
            }

        }

        private static Point changeDirection(byte direction)
        {
            int x = 0;
            int y = 0;

            switch (direction)
            {
                case 1: x = -15; break;
                case 2: x = 15; break;
                case 3: y = -15; break;
                case 4: y = 15; break;
            }

            return new Point(x, y);
        }

        public static Boolean isPointOfCollision(int x, int y)
        {
            if (x >= Control.width | x < 0)
            {         
                return true;
            }else if (y >= Control.heigth | y < 0)
            {
                return true;
            }
            
            return false;   
        }

        public static int getZOrderFromCoordinates(int x, int y)
        {
            int limit = 15 * Control.width;
            int increment = limit / 15;
            int Xposition = 0;
            int Yposition = 0;

            int i = 0;
            while (Xposition <= x)
            {
                Xposition += 15;
                i++;
            }

            int i2 = 0;
            while (Yposition <= y)
            {
                Yposition += 15;
                i2++;
            }

            i2--;
            int totalIncrement = i2 * increment;

            return (i + totalIncrement);
        }

        //public static Point getZOrderCoordinates(int z)
        //{
        //    int k = -1;
        //    int x;
        //    int y;
        //    double min = Math.Floor(z / Control.width);
        //    int limit = (int)(min * Control.width);

        //    for (int i = limit; i <= z; i++)
        //    {
        //        k++;
        //    }

        //    x = k * 15;
        //    min = Math.Ceiling((z / Control.width));
        //    y = (int)(min * 15);

        //    return new Point(x, y);
        //}

 
    }
}
