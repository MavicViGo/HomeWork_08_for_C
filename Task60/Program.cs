/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


bool CheckUnic(int[,,] matrix, int searcEl, bool un)
{
    for(int k = 0; k < matrix.GetLength(2); k++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {   
                if(matrix[i,j,k] == searcEl)
                {
                    un = true;
                    break;
                }
            }
        }
    }
}


void FillArray(int[,,] matrix)
{
    bool unic;
    for(int k = 0; k < matrix.GetLength(2); k++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {   
                unic = true;
                int newElement = new Random().Next(10,100);
                while (unic == true)
                {
                    newElement = new Random().Next(10,100);
                    unic = CheckUnic(matrix, newElement, unic);
                } 

            }
        }
    }
}


void PrintArray(int[,,] matrix)
{
    for(int k = 0; k < matrix.GetLength(2); k++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j,k]}({i},{j},{k})");   
                }
                Console.WriteLine();
        }
    }
}


Console.Clear();
int size = 2;
int[,,] array = new int[size,size,size];

FillArray(array);
//Console.WriteLine("Сгенерированный массив:");
PrintArray(array);