using System;
using static System.Console;

Clear();
Write("Введите номер столбца: ");
int column = int.Parse(ReadLine());
Write("Введите номер строки: ");
int row = int.Parse(ReadLine());

int[,] matrix = {{1, 4, 7, 2}, {5, 9, 3, 2}, {8, 4, 2, 4}};

if (column < 3 & row < 4)
{
    WriteLine(matrix[column, row]);
}
else
{
    WriteLine($"{column}{row} такого числа в массиве нет");
}