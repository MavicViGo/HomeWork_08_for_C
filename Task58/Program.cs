/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6
*/

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}


void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void MultiplicationArray(int[,] matrix1, int[,] matrix2, int[,] matrixRes)
{
    int tempRes;
    for(int i = 0; i < matrixRes.GetLength(0); i++)
    {
        for(int j = 0; j < matrixRes.GetLength(1); j++)
        {   
            tempRes = 0;
            for(int n  = 0; n < matrix1.GetLength(1); n++)
            {
                tempRes = tempRes + (matrix1[i,n] * matrix2[n,j]);
            }
            matrixRes[i,j] = tempRes;
        }
    }
}


Console.Clear();
Console.Write("Введите размер первого массива ч/з пробел: ");
int[] sizeFirst = Console.ReadLine()!
                        .Split()
                        .Select(x => int.Parse(x))
                        .ToArray();

Console.Write("Введите размер второго массива ч/з пробел: ");
int[] sizeSecond = Console.ReadLine()!
                          .Split()
                          .Select(x => int.Parse(x))
                          .ToArray();

int[,] arrayFirst = new int[sizeFirst[0], sizeFirst[1]];
int[,] arraySecond = new int[sizeSecond[0], sizeSecond[1]];

if(sizeFirst[1] != sizeSecond[0])
{
    Console.Write("Умножение данных матриц не возможно, матрицы не согласованы!");
    return;
}

int[,] arrayResult = new int[sizeFirst[0],sizeSecond[1]];
FillArray(arrayFirst);
FillArray(arraySecond);
Console.WriteLine("Первый исходный массив:");
PrintArray(arrayFirst);
Console.WriteLine("Второй исходный массив:");
PrintArray(arraySecond);
Console.WriteLine();
MultiplicationArray(arrayFirst, arraySecond, arrayResult);
Console.WriteLine("Массив полученный в результате умнжения:");
PrintArray(arrayResult);