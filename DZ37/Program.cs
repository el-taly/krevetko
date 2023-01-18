/// найти произведение пар чисел в одномерном массиве
// Парой считаем первый и последний элемент, второй и предпоследний
// Результат записать в новый массив

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

int[] res=GetArrey(7, -10, 10);
WriteLine($"{String.Join(",",res)}");
WriteLine();
for (int i=0; i<res.Length; i++)
{
    if (i<res.Length/2)
    {
    res[i]=res[i]*res[res.Length-1-i];
    Write($"{res[i]} ");
    }

}
WriteLine();
