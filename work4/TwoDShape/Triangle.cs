using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    class Triangle:Shape
    {
        private double edgeOne;
        private double edgeTwo;
        private double edgeThree;

        public Triangle()
        {
            Random ran = new Random();
            this.EdgeOne = ran.NextDouble() + ran.Next();
            this.EdgeTwo = ran.NextDouble() + ran.Next();
            this.EdgeThree = ran.NextDouble() + ran.Next();
        }

        public Triangle(double e1,double e2,double e3)
        {
            this.EdgeOne = e1;
            this.EdgeTwo = e2;
            this.EdgeThree = e3;
        }

        public double EdgeOne { get => edgeOne; set => edgeOne = value; }
        public double EdgeTwo { get => edgeTwo; set => edgeTwo = value; }
        public double EdgeThree { get => edgeThree; set => edgeThree = value; }

        public override double GetArea()
        {
            double p = (this.EdgeOne + this.EdgeTwo + this.EdgeThree)/2;
            return Math.Sqrt(p * (p - this.EdgeOne) * (p - this.EdgeTwo) * (p - this.EdgeThree));
        }

        public override string GetInfo()
        {
            return "三角形三边长分别为：" + this.EdgeOne +","+ this.EdgeTwo +","+ this.EdgeThree;
        }

        public override bool IsLegal()
        {
            double a = this.EdgeOne;
            double b = this.EdgeTwo;
            double c = this.EdgeThree;
            if (a<=0 || b<=0|| c<=0 || a + b <= c || a + c <= b || b + c <= a)
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
