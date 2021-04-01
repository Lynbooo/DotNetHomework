using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clock
{
    class AlarmClock
    {
        public event Action<AlarmClock> AlarmEvent;
        public event Action<AlarmClock> TickEvent;
        public ClockTime CurrentTime { get; set; }
        public ClockTime AlarmTime { get; set; }
        public AlarmClock()
        {
            CurrentTime = new ClockTime();
        }

        public void Run()
        {
            while (true)
            {
                DateTime time = DateTime.Now;
                CurrentTime = new ClockTime(time.Hour, time.Minute, time.Second);
                TickEvent(this);
                if (AlarmTime.Equals(CurrentTime))
                    AlarmEvent(this);
                Thread.Sleep(1000);
            }
        }
    }
}
