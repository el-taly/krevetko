// пользователь вводит с клавиатуры м чисел
// посчитать сколько чисел больше 0 ввел пользователь

using System;
using static System.Console;

Clear();

WriteLine("Введите элементы массива: ");

int[] GetArrey(int size, int minValue, int maxValue)
{
  int[] res =new int[size];
   for (int i=0; i<size; i++)
    {
      
        res[i]= int.Parse(ReadLine());
        
        
    }
    return res;
}
WriteLine();

int[] res=GetArrey(7, -10, 10);
Write($"{String.Join(",",res)}");

int summ=0;

foreach (int mau in res)
{
    if (mau>0) summ=summ+1;
}

WriteLine();
WriteLine(summ);

WriteLine();
