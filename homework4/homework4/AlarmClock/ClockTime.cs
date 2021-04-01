using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class ClockTime
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value > 24 || value < 0) throw new ArgumentOutOfRangeException("invalid hour");
                hour = value;
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value > 60 || value < 0) throw new ArgumentOutOfRangeException("invalid minute");
                minute = value;
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value > 60 || value < 0) throw new ArgumentOutOfRangeException("invalid second");
                second = value;
            }
        }

        public ClockTime(int hour = 0, int minute = 0, int second = 0)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public override bool Equals(object obj)
        {
            var time = obj as ClockTime;
            return (time != null && Hour == time.hour && Minute == time.minute && Second == time.second);
        }
        public override int GetHashCode()
        {
            var hashCode = Hour.GetHashCode() + Minute.GetHashCode() + Second.GetHashCode();
            return hashCode;
        }
    }
}
