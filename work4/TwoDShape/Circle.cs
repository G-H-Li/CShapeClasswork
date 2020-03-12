using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    class Circle:Shape
    {
        private double radius;

        public Circle()
        {
            Random ran = new Random();
            this.Radius = ran.NextDouble()+ran.Next();
        }

        public Circle(double r)
        {
            this.Radius = r;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override string GetInfo()
        {
            return "圆的半径为：" + this.Radius;
        }

        public override bool IsLegal()
        {
            if(this.Radius<=0)
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
