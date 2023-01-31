/// задать 2 матрицы
// найти произведение двух матриц

 

using System;
using static System.Console;

Clear();

int[,] matrItog= new int[3,3];

void Fillmatr(int [,] matr)
{

for (int i=0; i<matr.GetLength(0); i++)
{
    for (int j=0; j<matr.GetLength(1); j++)
    {
        matr[i,j]=new Random().Next(1,10);
        
    Write($"{matr[i ,j ]}  | ");
      
    }
    WriteLine();
}

}
 void Umnozh(int [,] matr1, int [,] matr2)
{

if (matr1.GetLength(1)!=matr2.GetLength(0))  throw new Exception("Такие матрицы нельзя умножать!!");


for (int i=0; i<matr1.GetLength(0); i++)
{
    for (int j=0; j<matr2.GetLength(1); j++)
    {
        for (int k=0; k<matr2.GetLength(1); k++)
    {
        matrItog[i,j]+=matr1[i,k]*matr2[k,j];
        
    }
   
   Write($"{matrItog[i,j]}  * ");
  
   
}
WriteLine();

}

}

int[,] matrix1 = new int[3,3];
int[,] matrix2 = new int[3,3];

Clear();
Fillmatr(matrix1);
WriteLine();
WriteLine();
Fillmatr(matrix2);
WriteLine();
Umnozh(matrix1,matrix2);
WriteLine();
