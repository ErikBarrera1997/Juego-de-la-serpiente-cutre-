
namespace Snake.Timer
{
    public abstract class Move : System.Timers.Timer
    {
        public Move()
        {
            Interval = 50;
            Elapsed += (s, e) => SetTik();
        }

        protected abstract void SetTik();

    }
}
