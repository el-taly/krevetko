// Задать двуиерный массив, размером mXn
// Заполненный случайными вещ. числами, m=3, n=4

using System;
using static System.Console;

Clear();

void FillArray(double [,] matr)
{
Random random = new Random();
for (int i=0; i<matr.GetLength(0); i++)
{
    for (int j=0; j<matr.GetLength(1); j++)
    {
        matr[i,j]=random.NextDouble()*100-50;
        Write($"{matr[i ,j ]:F2}  | ");
    }
   WriteLine();
}

}




double[,] matrix = new double[3,4];

FillArray(matrix);
WriteLine();