using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    class Square:Shape
    {
        private double edge;

        public Square()
        {
            Random ran = new Random();
            this.Edge = ran.NextDouble() + ran.Next();
        }

        public Square(double e)
        {
            this.Edge = e;
        }

        public override string GetInfo()
        {
            return "正方形边长为" + this.Edge;
        }

        public override double GetArea()
        {
            return this.Edge * this.Edge;
        }

        public override bool IsLegal()
        {
            if(this.Edge<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Edge { get => edge; set => edge = value; }
    }
}
