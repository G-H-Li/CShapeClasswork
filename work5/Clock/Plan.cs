using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    public class TimeException : ApplicationException
    {
        public TimeException(string msg) : base(msg) { }
    }


    class Plan
    {
        public AlarmClock clock = new AlarmClock();
        public int Hour { set; get; }
        public int Minute { set; get; }
        public int Second { set; get; }
        public string Thing { set; get; }

        public Plan()
        {
            try
            {
                Console.Write("输入闹钟响起的小时\n>>");
                this.Hour = Convert.ToInt32(Console.ReadLine());
                Console.Write("输入闹钟响起的分钟\n>>");
                this.Minute = Convert.ToInt32(Console.ReadLine());
                Console.Write("输入闹钟响起的秒数\n>>");
                this.Second = Convert.ToInt32(Console.ReadLine());
                Console.Write("输入你要做的事情\n>>");
                this.Thing = Console.ReadLine();
                this.IsLegal();
            }
            catch (FormatException e)
            {
                Console.WriteLine("输入的数据格式错误");
            }
            catch (TimeException e)
            {
                Console.WriteLine(e.Message + "不符合时间范围");
            }
            clock.OnRing += new ClockHandler(ClockOnRing);
            clock.OnTick += new ClockHandler(ClockOnTick);
        }

        private Plan(int h, int m, int s,string t)
        {
            this.Hour = h;
            this.Minute = m;
            this.Second = s;
            this.Thing = t;
            this.IsLegal();
        }

        void ClockOnRing(object sender)
        {
            Console.WriteLine($"铃铃铃！");
            Console.WriteLine("你要去 " + this.Thing + " 了");
        }

        void ClockOnTick(object sender)
        {
            Console.WriteLine("滴答 " + DateTime.Now.ToLongTimeString().ToString());
        }

        public bool Equals(int h,int m,int s)
        {
            if(h==this.Hour&&m==this.Minute&&s>=this.Second&&s<=this.Second+15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsLegal()
        {
            if(this.Hour<0||this.Hour>24)
            {
                throw new TimeException("Hour");
            }
            else if(this.Minute<0||this.Minute>60)
            {
                throw new TimeException("Minute");
            }
            else if (this.Second<0 || this.Second>60)
            {
                throw new TimeException("Second");
            }
            else
            {
                return true;
            }

        }
    }
}
