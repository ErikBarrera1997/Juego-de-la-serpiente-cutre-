using System;
using System.Windows.Forms;


namespace Snake.Game
{
    public abstract class Move : System.Timers.Timer
    {
        public Move()
        {
            this.Interval = 100;
            this.Elapsed += (s, e) => SetTik();
        }

        protected abstract void SetTik();

    }
}
