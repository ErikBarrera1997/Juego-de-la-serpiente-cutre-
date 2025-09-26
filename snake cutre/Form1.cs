using Snake.Game;
using Snake.Message;
using Snake.Timer;
using System.Diagnostics;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private movementTime mt;    
        //private countTime ct;

        public Form1()
        {
            InitializeComponent();
            mt = new movementTime();
            mt.Start();  
            //ct = new countTime();
            //ct.Start(); 
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

        /*
         * Dibuja el recuadro amarillo (border) en la pantalla principal.
        */
        private void border_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(
                e.Graphics,
                pictureBox1.ClientRectangle,
                Color.Yellow,
                ButtonBorderStyle.Solid 
            );


        }

        /*
         * Método que se usa para mostrar la serpiente mediante el timer.
        */
        private void screen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Point point in Element.getCoordinates())
            {
                g.FillRectangle(Brushes.Red, point.X, point.Y, 15, 15); 
            }


        }

    }

    internal class countTime : Count
    {
        public countTime() { }

        protected override void SetTik()
        {
            Game.Control.countTime++;
            verify(Mechanics.isPointOfCollision(Game.Control.x, Game.Control.y));
        }

        private void verify(Boolean isDisposable)
        {
            if(isDisposable)
               this.Dispose();
        }
    }


    internal class movementTime : Move
    {
        //Form container;

        public movementTime() 
        {
            Element.setInitialCoordinates(0, new Point(45, 15));
            Element.setInitialCoordinates(1, new Point(30, 15));
            Element.setInitialCoordinates(1, new Point(15, 15));

            //this.container = container;
        }
        
        protected override void SetTik()
        {
            Game.Mechanics.createCoordinates(Game.Control.getSense());
            Game.Control.getScreen().Invalidate();
            verify(Mechanics.isPointOfCollision(Game.Control.x, Game.Control.y));
        }

        private void verify(Boolean isDisposable)
        {
            if (isDisposable)
                this.Dispose();
        }

    }
}
