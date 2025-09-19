using Snake.Game;
using Snake.Message;
using System.Diagnostics;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private Time t;    

        public Form1()
        {
            InitializeComponent();
            t = new Time(this);
            t.Start();  
        }

        private void keyDown_event(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Game.Control.setSense(1); break; 
                case Keys.Right:
                    Game.Control.setSense(2); break;
                case Keys.Up:
                    Game.Control.setSense(3); break;
                case Keys.Down:
                    Game.Control.setSense(4); break;
            }
        }

        private void border_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(
                e.Graphics,
                pictureBox1.ClientRectangle,
                Color.Yellow,
                ButtonBorderStyle.Solid 
            );


        }


        private void screen_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
           // int x = Game.Control.x;
            //int y = Game.Control.y;

            //g.FillRectangle(Brushes.Red, x, y, 15, 15);    ///solo desde aqui va a dibujar desde la lista de rectangulos

            
            foreach (Point point in Element.getCoordinates())
            {
                g.FillRectangle(Brushes.Red, point.X, point.Y, 15, 15); //Debug.WriteLine(Element.getCoordinates().Count);
                //e.Graphics.FillRectangle(Brushes.Red, shape, x, y, 15, 15);
            }


        }

    }

    internal class Time : Game.Move
    {
        Form container;

        public Time(Form container) 
        {
            Element.setInitialCoordinates(0, new Point(45, 15));
            Element.setInitialCoordinates(1, new Point(30, 15));
            Element.setInitialCoordinates(1, new Point(15, 15));

            this.container = container;
        }
        
        protected override void SetTik()
        {
            Game.Mechanics.createCoordinates(Game.Control.getSense());
            Game.Control.getScreen().Invalidate();
            getMessage(Mechanics.isPointOfCollision(Game.Control.x, Game.Control.y));
        }

        private void getMessage(Boolean flag)
        {
            Debug.WriteLine(flag);
            if (flag)
            {              
                this.Dispose();
                Message.Messages.getGameOverMessage(container, flag);
            }

        }
    }
}
