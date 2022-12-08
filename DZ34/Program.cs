// массив, наполненный случайными положительными числами трехзначными
// написать программу, которая покажет кол-во четных
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
int[] array=GetArrey(10,100,999);
int count=0;

foreach (int mau in array)
{
    if (mau%2==0) count++;
}

WriteLine();
WriteLine(count);