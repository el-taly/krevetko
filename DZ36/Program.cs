// массив, наполненный случайными числами
// написать программу, которая покажет сумму нечетных элементов

using System;
using static System.Console;

Clear();


int[] GetArrey(int size, int minValue, int maxValue)
{
    int[] res =new int[size];
    for (int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array=GetArrey(10,-100,100);
int summ=0;

foreach (int mau in array)
{
    if (mau%2!=0) summ=summ+mau;
}

WriteLine();
WriteLine(summ);
