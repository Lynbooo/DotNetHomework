using System;

public class PrimeNumber
{
	public void Prime(int data)
	{
        int i = 2;
        Console.Write($"{data}'s prime factor: "); 
        while ((i <= data) && (data != 1))
        {
            if (data % i == 0)
            {
                Console.Write($"{i} ");
                data /= i;
            }
            else
                i++;
        }
        Console.WriteLine();
    }
}
