using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    public delegate void ClockHandler(Object sender);

    class AlarmClock
    {
        public event ClockHandler OnRing;
        public event ClockHandler OnTick;

        public void Alarm(int hour,int minute,int second)
        {
            while(true)
            {
                TimeSpan Interval = TimeSpan.FromMilliseconds(1000);
                System.Threading.Thread.Sleep(Interval);
                // 闹钟响动15s
                if (DateTime.Now.Hour==hour && DateTime.Now.Minute==minute && DateTime.Now.Second>=second && DateTime.Now.Second <= second+15)
                {
                    OnRing(this);
                }
                OnTick(this);
            }
        }
    }
}
