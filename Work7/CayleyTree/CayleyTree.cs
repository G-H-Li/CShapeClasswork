using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayleyTree
{
    class CayleyTree
    {
        Graphics graphics;
        double rightAngle;
        double leftAngle;
        double rightPer;
        double leftPer;
        double length;
        int recursion;
        Pen color;

        public CayleyTree()
        {
            this.Graphics = null;
            this.Length = 100;
            this.Recursion = 10;
            this.RightAngle = 30 * Math.PI / 180;
            this.LeftAngle = 20 * Math.PI / 180;
            this.RightPer = 0.6;
            this.LeftPer = 0.7;
            this.Color = Pens.Blue;
        }

        public CayleyTree(int n, double l, double rA, double lA, double rP, double lP)
        {
            this.Graphics = null;
            this.Color = null;
            this.Recursion = n;
            this.Length = l;
            this.RightAngle = rA;
            this.LeftAngle = lA;
            this.RightPer = rP;
            this.LeftPer = lP;
        }

        public void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            this.DrawLine(x0, y0, x1, y1);

            this.DrawCayleyTree(n - 1, x1, y1, this.RightPer * leng, th + this.RightAngle);
            this.DrawCayleyTree(n - 1, x1, y1, this.LeftPer * leng, th - this.LeftAngle);
        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            this.Graphics.DrawLine(this.Color, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        public double RightAngle { get => rightAngle; set => rightAngle = value; }
        public double LeftAngle { get => leftAngle; set => leftAngle = value; }
        public double RightPer { get => rightPer; set => rightPer = value; }
        public double LeftPer { get => leftPer; set => leftPer = value; }
        public Graphics Graphics { get => graphics; set => graphics = value; }
        public int Recursion { get => recursion; set => recursion = value; }
        public double Length { get => length; set => length = value; }
        public Pen Color { get => color; set => color = value; }
    }
}
