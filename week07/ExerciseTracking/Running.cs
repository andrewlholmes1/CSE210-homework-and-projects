using System;

namespace ActivityTracker
{
    public class Running : Activity
    {
        private double _distanceMiles;

        public Running(DateTime date, int durationMinutes, double distanceMiles)
            : base(date, durationMinutes)
        {
            _distanceMiles = distanceMiles;
        }

        public override double GetDistance() => _distanceMiles;
        public override double GetSpeed() => (_distanceMiles / _durationMinutes) * 60;
        public override double GetPace() => _durationMinutes / _distanceMiles;
    }
}