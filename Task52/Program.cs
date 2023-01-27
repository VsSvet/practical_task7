using System;
using static System.Console;

Clear();
Write("Введите количество столбцов: ");
int M = int.Parse(ReadLine());
Write("Введите количество строк: ");
int N = int.Parse(ReadLine());

int[,] result = new int[M, N];

WriteLine("Заданный массив: ");
for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        
        result[i, j] = new Random().Next(10);
        Write($"{result[i,j]} ");
    }
    WriteLine();
}

Write("Среднее арифметическое каждого столбца: ");

for(int i = 0; i < N; i++)
{
    float sum = 0;
    for(int j = 0; j < M; j++)
    {
        sum += result[j, i];
    }
    Write($"{sum/M}; "); 
}

