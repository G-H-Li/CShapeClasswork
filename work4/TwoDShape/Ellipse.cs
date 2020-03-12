using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    class Ellipse:Shape
    {
        private double lAxis;
        private double sAxis;

        public Ellipse()
        {
            Random ran = new Random();
            this.LAxis = ran.NextDouble() + ran.Next();
            this.SAxis = ran.NextDouble() + ran.Next();
        }

        public Ellipse(double l,double s)
        {
            this.LAxis = l;
            this.SAxis = s;
        }

        public double LAxis { get => lAxis; set => lAxis = value; }
        public double SAxis { get => sAxis; set => sAxis = value; }

        public override double GetArea()
        {
            return Math.PI * this.LAxis * this.SAxis / 4;
        }

        public override string GetInfo()
        {
            double max = this.LAxis >= this.SAxis ? this.LAxis : this.SAxis;
            double min= this.LAxis >= this.SAxis ? this.SAxis : this.LAxis;
            return "椭圆的长轴为" + max + ",短轴为" + min;
        }

        public override bool IsLegal()
        {
            if(this.LAxis<=0||this.SAxis<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
