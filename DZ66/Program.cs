// программа принимает на вход числа M и N
// помощью рекурсии находит сумму всех натуральных элементов между ними



using System;
using static System.Console;

Clear();

Write("Введите число: ");
int N=int.Parse(ReadLine());
WriteLine();

Write("Введите число: ");
int M=int.Parse(ReadLine());
WriteLine();



string NumberRec(int M, int N)
{
    if (M<=N) return NumberRec(M+1,N) + $"{M} ";
    else return String.Empty;
}

WriteLine(NumberRec(M,N));
