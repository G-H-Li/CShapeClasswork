using System;

namespace TwoDShape
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shapes = { "Rectangle", "Triangle", "Square", "Circle", "Ellipse" };
            Random ran = new Random();
            double area = 0;
            int i = 0;
            Shape shape;
            while(i<10)
            {
                shape=GetShape(shapes[ran.Next(0, 5)]);
                if (shape.IsLegal())
                {
                    area += shape.GetArea();
                    Console.WriteLine(shape.GetInfo());
                    i += 1;
                }
            }
            Console.WriteLine("十个随机形状面积之和为：" + area);
        }

        static Shape GetShape(string args)
        {
            Shape shape = null;
            if(args.Equals("Rectangle"))
            {
                shape = new Rectangle();
            }
            else if(args.Equals("Triangle"))
            {
                shape = new Triangle();
            }
            else if(args.Equals("Square"))
            {
                shape = new Square();
            }
            else if(args.Equals("Circle"))
            {
                shape = new Circle();
            }
            else if(args.Equals("Ellipse"))
            {
                shape = new Ellipse();
            }
            return shape;
        }
    }
}
