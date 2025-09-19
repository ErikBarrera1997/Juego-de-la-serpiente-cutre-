using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Game
{
    public class Control
    {
        private static PictureBox screen = new PictureBox();
        private static byte sense = 2;
        private static int collision;

        public static int x { get; set; } = 0;
        public static int y { get; set; } = 0;
        public static int width { get; set; } = 0;
        public static int heigth { get; set; } = 0;
        public static int pointOfCollision { get; set; }   

        public static PictureBox getScreen()
        {
            return screen;
        }

        public static void setSense(byte d)
        {
            sense = d;
        }

        public static Byte getSense()
        {
            return sense;
        }



    }
}
