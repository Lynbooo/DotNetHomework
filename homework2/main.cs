using System;

namespace homework2
{
    class main
    {
        static void Main(string[] args)
        {
            //1
            string s = "";
            Console.Write("please input an int:");
            s = Console.ReadLine();
            int data = int.Parse(s);
            PrimeNumber h1 = new PrimeNumber();
            h1.Prime(data);
            //2
            ArrayCalculation h2 = new ArrayCalculation();
            h2.Calculation();
            //3
            SieveOfEratosthenes h3 = new SieveOfEratosthenes();
            h3.Eratosthenes();
            //4
            ToeplitzMatrix h4 = new ToeplitzMatrix();
            if (h4.IsToeplitzMatrix())
            {
                Console.WriteLine("it is a Toeplitz Matrix.");
            }
            else
            {
                Console.WriteLine("it is not a Toeplitz Matrix.");
            }
        }
    }
}
