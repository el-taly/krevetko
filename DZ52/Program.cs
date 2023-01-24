// задать двумерный массив из целых чисел
// найти среднее арифметическое в каждом столбце


using System;
using static System.Console;

Clear();


void FillArray(int [,] matr)
{

for (int i=0; i<matr.GetLength(0); i++)
{
    for (int j=0; j<matr.GetLength(1); j++)
    {
        matr[i,j]=new Random().Next(1,100);
        
        Write($"{matr[i ,j ]}  | ");
    }
    WriteLine();
}

}


void SredneeArifm(int [,] matr)

{
   double summ=0;
   double rez=0;
   
   for (int j=0; j<matr.GetLength(1); j++)
{
    
    for (int i=0; i<matr.GetLength(0); i++)
    {
        if (j<matr.GetLength(1))
        {
        summ = summ+matr[i,j];
        }
        
    }
    rez = summ/(matr.GetLength(1)-1);
    WriteLine($"Среднее арифметическое = { rez:F2}");
    summ=0;
}
}   

int[,] matrix = new int[3,4];

Clear();
FillArray(matrix);
WriteLine();
SredneeArifm(matrix);
WriteLine();
