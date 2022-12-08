using System;
using static System.Console;

Clear();

Write("Введите A: ");
int A=int.Parse(ReadLine());

Write("Введите B: ");
int B=int.Parse(ReadLine());


WriteLine($"{Math.Pow(A,B)}");

