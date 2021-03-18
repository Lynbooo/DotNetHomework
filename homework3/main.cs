using System;
using System.Threading;

namespace homework3
{
    class main
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle(5,8);
            Rectangle r2 = new Rectangle(-1, -2);
            if (!r1.IsValid())
            {
                Console.WriteLine("rectangle1 is not a rectangle!");
            }
            else
            {
                r1.ComputeArea();
                Console.WriteLine($"rectangle1's area = {r1.Area}");
            }
            if (!r2.IsValid())
            {
                Console.WriteLine("rectangle2 is not a rectangle!");
            }
            else
            {
                r2.ComputeArea();
                Console.WriteLine($"rectangle2's area = {r1.Area}");
            }

            Triangle t1 = new Triangle(5, 12, 13);
            if (!t1.IsValid ())
            {
                Console.WriteLine("Triangle1 is not a triangle!");
            }
            else
            {
                t1.ComputeArea();
                Console.WriteLine($"Triangle1's area = {t1.Area}");
            }

            Square s1 = new Square(8);
            if (!s1.IsValid())
            {
                Console.WriteLine("Square1 is not a square!");
            }
            else
            {
                s1.ComputeArea();
                Console.WriteLine($"Square1's area = {s1.Area}");
            }

            CreatShape creator = new CreatShape();
            Random rd = new Random();
            int type = 0;
            double sumOfArea = 0;
            for(int i = 0; i < 11; i++)
            {
                type = rd.Next(1, 4);
                Shape shape = creator.Create(type);
                shape.ComputeArea();
                Console.WriteLine(shape.Area);
                sumOfArea += shape.Area;
                Thread.Sleep(1);
            }
            Console.WriteLine($"the sum of area = {sumOfArea}");
        }
    }
}
