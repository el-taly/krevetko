/// задать прямоугольный двумерный массив из целых чисел
// программа считает сумму элементов строки, находит наименьшею
// выдает наименьшую сумму и номер строки
 

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

void Naimsumma(int [,] matr)

{
   int summ=0;
   
    int [] rez = new int[matr.GetLength(0)];
    
   
   for (int i=0; i<matr.GetLength(0); i++)
{
    summ=0;
    for (int j=0; j<matr.GetLength(1); j++)
    {
        if (j<matr.GetLength(1))
        {
        summ = summ+matr[i,j];
        }
           
    }  
    rez[i]=summ; 
    
   WriteLine($"сумма = { summ}, номер строки = {i}");

    
}
WriteLine($"{String.Join(",",rez)}");

int minPos=rez[0];
int k=0;
for (int i=0; i<rez.Length-1; i++)
{
    
if (rez[i]<minPos) 
{minPos=rez[i];
k=i;
}

}   

    WriteLine($"Наименьшая сумма = { minPos}, Номер строки {k}");
}

int[,] matrix = new int[3,4];

Clear();
FillArray(matrix);
WriteLine();
Naimsumma(matrix);
WriteLine();
