using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    class Rectangle:Shape
    {
        private double width;   // 矩形的宽
        private double length;  // 矩形的长

        public Rectangle()
        {
            Random ran = new Random();
            this.Width = ran.NextDouble()+ran.Next();
            this.Length = ran.NextDouble() + ran.Next();
        }

        public Rectangle(double w,double l)
        {
            this.Width = w;
            this.Length = l;
        }

        public override double GetArea()
        {
            return this.Width * this.Length;
        }

        public override string GetInfo()
        {
            double max = this.Length >= this.Width ? this.Length : this.Width;
            double min = this.Length >= this.Width ? this.Width : this.Length;
            return "矩形长为" + max + "宽为" + min;
        }

        public override bool IsLegal()
        {
            if (this.Width<=0 || this.Length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Length { get => length; set => length = value; }

        public double Width { get => width; set => width = value; }
    }
}
