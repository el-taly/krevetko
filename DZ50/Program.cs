// программа принимает на вход число
// проверяет, сеть ли такое число в двухмерном массиве
// сообщает,что оно найдено, или указывает, что его нет


using System;
using static System.Console;

Clear();

Write("Введите число: ");
int numb=int.Parse(ReadLine());
WriteLine();


void FillArray(int [,] matr)
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


void Sravnenie(int [,] matr)

{
    bool rez = false;
    foreach (int mau in matr)
{
    if (mau == numb)
    {
    rez = true;
    break;
    }
}
    if (rez)
   WriteLine($"Такое число есть = {numb}");
   else
   WriteLine($"Такого числа нет!");

Console.WriteLine();

}
    
    WriteLine();

int[,] matrix = new int[3,4];


FillArray(matrix);
WriteLine();
Sravnenie(matrix);
WriteLine();
