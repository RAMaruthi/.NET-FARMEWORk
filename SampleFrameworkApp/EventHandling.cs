using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    delegate void CallMe(string msg);
    class Clock
    {
        private static DateTime _alarmTime;
            public static event CallMe OnAlarmTime;
        public static void SetAlarm(DateTime time)
        {
            _alarmTime = time;
        }
        public static void DisplayClock()
        {
            do
            {
                if (DateTime.Now.Minute == _alarmTime.Minute)
                {
                    if (OnAlarmTime != null)
                    {
                        OnAlarmTime("Time to go to break!!!");
                        Console.Beep(2344, 10000);
                    }
                }
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
                Console.Clear();
            } while (true);
        }
    }
    class EventHandling
    {
        static void Main(string[] args)
        {
                Clock.OnAlarmTime += Clock_OnAlarmTime;
            Clock.SetAlarm(DateTime.Now.AddMinutes(1));
            Clock.DisplayClock();
        }

        private static void Clock_OnAlarmTime(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}



