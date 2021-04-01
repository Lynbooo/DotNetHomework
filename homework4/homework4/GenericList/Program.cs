using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for (int i = 1; i < 30; i += 3)
            {
                intList.Add(i);
            }
            intList.ForEach(m => Console.Write($"{m} "));
            int sum = 0, max = 0, min = 30;
            intList.ForEach(m =>
            {
                sum += m;
                max = (max < m) ? m : max;
                min = (min > m) ? m : min;
            });
            Console.WriteLine();
            Console.WriteLine($"sum={sum}, max={max}, min={min}");
        }
    }
}
