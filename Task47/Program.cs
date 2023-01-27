using System;
using static System.Console;

Clear();
Write("Введите размер m: ");
int M = int.Parse(ReadLine());
Write("Введите размер n: ");
int N = int.Parse(ReadLine());


double[,] result = new double[M, N];

for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        result[i, j] = Math.Round(new Random().NextDouble()*10 -1, 1);
        Write($"{result[i,j]} ");    
    }
    WriteLine();
}
