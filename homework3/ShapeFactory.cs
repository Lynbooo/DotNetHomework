using System;

namespace homework3
{
    //abstract class Shape
    //{
    //    protected double area = 0;
    //    public abstract bool IsAShape();
    //    public abstract double ComputeArea();
    //    public abstract double Area { get; }
    //}
    public class CreatShape
    {
        Random rd = new Random();
        public Shape Create(int args)
        {
            double num1 = rd.Next(1, 10);
            double num2 = rd.Next(1, 10);
            double num3 = rd.Next(1, 10);
            if (args == 1)
            {
                num1 = rd.Next(1, 10);
                Square s = new Square(num1);
                //do
                //{
                //    s = new Square(num1);
                //} while (!s.IsValid());
                return s;
            }
            if (args == 2)
            {
                num1 = rd.Next(1, 10);
                num2 = rd.Next(1, 10);
                Rectangle r = new Rectangle(num1, num2);
                //do
                //{
                //    r = new Rectangle(rd.Next(1, 10), rd.Next(1, 10));
                //} while (!r.IsValid());
                return r;
            }
            if (args == 3)
            {
                Triangle t = new Triangle(num1, num2, num3);
                do
                {
                    num1 = rd.Next(1, 10);
                    num2 = rd.Next(1, 10);
                    num3 = rd.Next(1, 10);
                    t = new Triangle(num1, num2, num3);
                } while (!t.IsValid());
                return t;
            }
            else
            {
                throw new NotImplementedException("Invalid!");
            }
        }
    }

}
