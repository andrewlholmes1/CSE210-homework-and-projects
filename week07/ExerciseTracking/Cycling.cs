using System;

namespace ActivityTracker
{
    public class Cycling : Activity
    {
        private double _speedMph;

        public Cycling(DateTime date, int durationMinutes, double speedMph)
            : base(date, durationMinutes)
        {
            _speedMph = speedMph;
        }

        public override double GetDistance() => _speedMph * _durationMinutes / 60;
        public override double GetSpeed() => _speedMph;
        public override double GetPace() => 60 / _speedMph;
    }
}