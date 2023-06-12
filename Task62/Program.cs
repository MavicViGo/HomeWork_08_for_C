/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillArray(int[,] matrix)
{   
    int j, i, newElement = 1, n=0;
    while(newElement < 4* 4)
    {
    j = 0+n; 
    i = 0+n; 
    while(j < matrix.GetLength(1)-n)  //движемся вправо
    {
        matrix[i,j] = newElement;
        newElement++;
        j++;
    }
        i ++;
        j = matrix.GetLength(1)-1;
    while(i+n < matrix.GetLength(0)-n)  //движемся вниз
    {   
        matrix[i,j] = newElement;
        newElement++;
        i++;
    }
        j=j-1;
        i = matrix.GetLength(1)-1-n;
    while(j >= 0+n)  //движемся влево
    {   
        matrix[i,j] = newElement;
        newElement++;
        j--;
    } 
     if(newElement>15)
    break;    
        i=i-1+n;
        j=0+n;
    while(i+n > 0+n)  //движемся вверх
    {   
        matrix[i,j] = newElement;
        newElement++;
        i--;
    }
    n++;
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



Console.Clear();
int size = 4;
int[,] array = new int[size,size];

FillArray(array);

Console.WriteLine("");
PrintArray(array);