using System;

namespace homework3
{
    public abstract class Shape
    {
        protected double area = 0;
        public abstract bool IsValid();
        public abstract double ComputeArea();
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        private double length = 0;
        private double width = 0;
        public Rectangle(double l, double w)
        {
            length = l; width = w;
        }
        public override bool IsValid()
        {
            if (length <= 0 | width <= 0)
            {
                return false;
            }
            return true;
        }
        public override double ComputeArea()
        {
            if (IsValid())
            {
                return area = length * width;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public override double Area
        {
            get => area;
        }
    }

    public class Triangle : Shape
    {
        private double edge1 = 0, edge2 = 0, edge3 = 0;
        public Triangle(double e1, double e2, double e3)
        {
            edge1 = e1; edge2 = e2; edge3 = e3;
        }
        public override bool IsValid()
        {
            if (edge1 <= 0 | edge2 <= 0 | edge3 <= 0)
            {
                return false;
            }
            else if (edge1 >= (edge2 + edge3) | edge2 >= (edge1 + edge3) | edge3 >= (edge1 + edge2))
            {
                return false;
            }
            return true;
        }
        public override double ComputeArea()
        {
            if (IsValid())
            {
                double p = (edge1 + edge2 + edge3) / 2;
                return area = (Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3)));
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public override double Area
        {
            get => area;
        }

    }

    public class Square : Shape
    {
        private double length = 0;
        public Square(double l)
        {
            length = l;
        }
        public override bool IsValid()
        {
            if (length <= 0)
            {
                return false;
            }
            return true;
        }
        public override double ComputeArea()
        {
            if (IsValid())
            {
                return area = length * length;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public override double Area
        {
            get => area;
        }
    }
}