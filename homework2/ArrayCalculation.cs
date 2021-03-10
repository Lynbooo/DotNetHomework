using System;

namespace homework2
{
    public class ArrayCalculation
    {
        public void Calculation()
        {
            int[] intArray = new int[8] { 33, 67, 12, 98, 55, 76, 2, 34 };
            int sumValue = 0, maxValue = 0, minValue = 2147483647;
            Console.Write("in array: ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{intArray[i]} ");
                sumValue += intArray[i];
                maxValue = (intArray[i] > maxValue) ? intArray[i] : maxValue;
                minValue = (intArray[i] < minValue) ? intArray[i] : minValue;
            }
            double averageValue = sumValue / 8;
            Console.WriteLine();
            Console.WriteLine($"maxValue:{maxValue} minValue:{minValue} averageValue:{averageValue} sumValue:{sumValue}");
        }
    }
}
