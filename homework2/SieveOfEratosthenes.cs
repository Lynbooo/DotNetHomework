using System;

public class SieveOfEratosthenes
{
	public void Eratosthenes()
	{
		int[] number = new int[101];
        for (int i = 2; i <= 100; i++)
        {
            number[i] = 1;
        }
		for(int i = 2; i <= 100; i++)
        {
            if (number[i] == 1)
            {
                for(int j = 2; i * j <= 100; j++)
                {
                    number[i * j] = 0;
                }
            }
        }
        Console.WriteLine("Prime number in 2-100:");
        for (int i = 2; i <= 100; i++)
        {
            if (number[i] == 1)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();

    }
}
