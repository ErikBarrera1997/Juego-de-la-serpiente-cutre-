
namespace Snake.Timer
{
    public abstract class Count : System.Timers.Timer
    {
        public Count()
        {
            this.Interval = 1000;
            this.Elapsed += (s, e) => SetTik();
        }

        protected abstract void SetTik();

        
    }
}
