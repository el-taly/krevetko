// Задать трехмерный массив, из неповторяющихся двухзначных чисел
// написать программу, которая будет выводить построчно массив, добавляя индексы каждого элемента

using System;
using static System.Console;

Clear();

void FillArray(int [ , , ] matr)
{
    
    
for (int i=0; i<matr.GetLength(0); i++)
{
    WriteLine("1 измерение: " + i);
    for (int j=0; j<matr.GetLength(1); j++)
    {
        for (int k=0; k<matr.GetLength(2); k++)
    {
        matr[i,j,k]=new Random().Next(10,99);
        //Write($"{matr[i ,j , k]} ({i},{j},{k}), | ");
        for (int z = 0; z < k; z++)
        {
              if (matr[i, j, z] == matr[i, j, k])
                 k--;
        }
       Write($"{matr[i ,j , k]} ({i},{j},{k}), | ");
    }
     
   WriteLine();
}
WriteLine("=============================");
}
}


int[,,] matrix = new int[2,2,2];


Clear();
FillArray(matrix);
WriteLine();