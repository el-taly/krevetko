// на вход массив из любого кол-ва элементов, не менее 6-ти от 0 до 100
// на выходе этот же массив отсортированный по возрастанию

using System;
using static System.Console;

Clear();

int[] GetArrey(int size, int minValue, int maxValue)
{
    int[] res =new int[size];
    for (int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);
        
        
    }
    return res;
}
WriteLine();

void Sort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
{
    int minPos=i;

    for (int j=i+1; j<array.Length; j++)
    {
if (array[j]< array[minPos]) minPos=j;

    }
    int temporary=array[i];
    array[i]=array[minPos];
    array[minPos]=temporary;
}
}


int[] res=GetArrey(10, 0, 100);
WriteLine($"{String.Join(",",res)}");
WriteLine();
Sort(res);
WriteLine($"{String.Join(",",res)}");
