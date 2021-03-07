using System;

namespace counter_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";          // s用于接收数据
            Console.Write("Please input x: ");
            s = Console.ReadLine();
            double x = double.Parse(s);
            Console.Write("Please input y: ");
            s = Console.ReadLine();
            double y = double.Parse(s);
            string theOperator = "";// 运算符
            while (theOperator != "exit")
            {
                Console.Write("Please input operator (input 'exit' to quit.): ");
                theOperator = Console.ReadLine();
                switch (theOperator)
                {
                    case "+":
                        Console.WriteLine($"{x} + {y} = {x + y}");
                        break;
                    case "-":
                        Console.WriteLine($"{x} - {y} = {x - y}");
                        break;
                    case "*":
                        Console.WriteLine($"{x} * {y} = {x * y}");
                        break;
                    case "/":
                        Console.WriteLine($"{x} / {y} = {x / y}");
                        break;
                    case "%":
                        Console.WriteLine($"{x} % {y} = {x % y}");
                        break;
                    case "exit":
                    default:
                        Console.WriteLine("can't caculate");
                        break;
                }
            }
        }
    }
}
