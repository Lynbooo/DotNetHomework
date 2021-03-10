using System;

public class ToeplitzMatrix
{
	public bool IsToeplitzMatrix()
	{
		int[,] matrix = new int[3, 4]
		{
			{1,2,3,4 },
			{5,1,2,3 },
			{9,5,1,2 }
		};
		Console.WriteLine("Matrix: ");
		for (int i = 0; i < 3; i++)
        {
			Console.Write("| ");
			for(int j = 0; j < 4; j++)
            {
				Console.Write($"{matrix[i, j]} ");

			}
			Console.Write("|");
			Console.WriteLine();
		}
		for(int i = 0; i < 2; i++)
        {
			for (int j = 0; j < 3; j++)
            {
				if (matrix[i, j] != matrix[i + 1, j + 1])
                {
					return false;
				}
            }
        }
		return true;
	}
}
