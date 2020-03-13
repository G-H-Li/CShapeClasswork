using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Plan plan1 = new Plan();
            plan1.clock.Alarm(plan1.Hour,plan1.Minute,plan1.Second);
        }
    }
}
