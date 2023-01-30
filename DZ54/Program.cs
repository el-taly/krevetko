/// задать двумерный массив из целых чисел
// упорядочить по убыванию элементы в каждой строке


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


void Poryadok(int [,] matr)

{

    for (int i=0; i<matr.GetLength(0); i++)
{
    for (int j=0; j<matr.GetLength(1); j++)
 {  
   for (int k=0; k<matr.GetLength(1)-j-1; k++)
{
    if (matr[i, j] >matr[i, k+1])
    {
     int temp = matr [i, k];
        matr[i, k] = matr[i, k+1];
        matr[i, k+1] = temp;
        
    }  
  
            
}
Write($"{matr[i,j]}," , "");

}
   WriteLine ();
}

}
   

int[,] matrix = new int[2,2];

Clear();
FillArray(matrix);
WriteLine();
Poryadok(matrix);
WriteLine();
