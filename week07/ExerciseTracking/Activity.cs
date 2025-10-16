using System;

namespace ActivityTracker
{
    public abstract class Activity
    {
        protected DateTime _date;
        protected int _durationMinutes;

        public Activity(DateTime date, int durationMinutes)
        {
            _date = date;
            _durationMinutes = durationMinutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_durationMinutes} min) - " +
                   $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
        }
    }
}