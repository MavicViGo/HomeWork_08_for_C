/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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


int SumRow(int[,] matrix, int numRow)
{
    int sumRow = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        sumRow = sumRow + matrix[numRow,i];
    }
    return sumRow;
}


Console.Clear();
Console.Write("Введите размер массива ч/з пробел: ");
int[] size = Console.ReadLine()!
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray();
int[,] array = new int[size[0], size[1]];
FillArray(array);
PrintArray(array);

int[] sumRow = new int[size[0]];
for(int i = 0; i < sumRow.Length; i++)
{
    sumRow[i] = SumRow(array, i);
}

int minSumRow = sumRow[0], numRow = 0;
for(int i = 1; i < sumRow.Length; i++)
{
    if(minSumRow > sumRow[i])
    {
        numRow = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов №: {numRow+1}");