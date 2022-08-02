/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

int SumLineElements(int[,] matrix, int i)
{
    int sum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return sum;
}

Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());


int[,] matrix = InitMatrix(m, n);



Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();


PrintMatrix(matrix);
Console.WriteLine();

int minSumLine = 0;
int sum = SumLineElements(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(matrix, i);
    if (sum > tempSumLine)
    {
        sum = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sum}) элементов ");