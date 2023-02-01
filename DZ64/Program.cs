// программа принимает на вход число N
// помощью рекурсии выводит все натуральные числа от N до 1



using System;
using static System.Console;

Clear();

Write("Введите число: ");
int N=int.Parse(ReadLine());
WriteLine();



string NumberRec(int a, int N)
{
    if (a<=N) return NumberRec(a+1,N) + $"{a} ";
    else return String.Empty;
}

WriteLine(NumberRec(1,N));





