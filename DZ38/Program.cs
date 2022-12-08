// массив, наполненный случайными вещественными числами
// найти разницу между max и min элементами массивами

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
int max=0;
int min=0;

foreach (int mau in array)
{
    if (mau>max) max=mau;
    if (mau<min) min=mau;
}
int razn=max-min;

WriteLine();
WriteLine(max);
WriteLine(min);
WriteLine(razn);

