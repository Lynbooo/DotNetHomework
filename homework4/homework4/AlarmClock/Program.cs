using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock1 = new AlarmClock();
            clock1.AlarmTime = new ClockTime(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second + 10);
            clock1.TickEvent += ShowTime;
            clock1.AlarmEvent += Alarm;
            clock1.Run();
        }
        private static void ShowTime(AlarmClock sender)
        {
            ClockTime time = sender.CurrentTime;
            Console.WriteLine($"Tick in {time.Hour}:{time.Minute}:{time.Second}");
        }
        private static void Alarm(AlarmClock sender)
        {
            ClockTime time = sender.CurrentTime;
            Console.WriteLine($"Alarm in {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine("bell is ring!");
        }
    }
}
