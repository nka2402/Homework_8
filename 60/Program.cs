/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

void InitMatrix(int[,,] matrix3d)
{
    int[] mtx = new int[matrix3d.GetLength(0) * matrix3d.GetLength(1) * matrix3d.GetLength(2)];
    int number;
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        mtx[i] = new Random().Next(10, 100);
        number = mtx[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (mtx[i] == mtx[j])
                {
                    mtx[i] = new Random().Next(10, 100);
                    j = 0;
                    number = mtx[i];
                }
                number = mtx[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix3d.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3d.GetLength(1); y++)
        {
            for (int z = 0; z < matrix3d.GetLength(2); z++)
            {
                matrix3d[x, y, z] = mtx[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива X x Y x Z: ");
Console.WriteLine("Введите число x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число y:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число z:");
int z = int.Parse(Console.ReadLine());

int[,,] matrix3d = new int[x, y, z];
InitMatrix(matrix3d);
Console.WriteLine();
PrintArray(matrix3d);