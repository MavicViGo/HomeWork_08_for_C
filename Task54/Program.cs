/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 100);
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


void SortRowArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {   
        int temp = 0;
        for(int j = 0; j < matrix.GetLength(1)-1; j++)
        {   
            for(int m = 0; m < matrix.GetLength(1)-1 -j; m++)
            {
                if(matrix[i,m] < matrix[i,m+1])
                {
                    temp = matrix[i,m+1];
                    matrix[i,m+1] = matrix[i,m];
                    matrix[i,m] = temp;
                }
            }    
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива через пробел: ");
int[] size = Console.ReadLine()!
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray();
int[,] array = new int [size[0], size[1]];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
SortRowArray(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(array);