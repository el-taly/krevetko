using System;
using static System.Console;

Clear();

Write("Введите N: ");
int N=int.Parse(ReadLine());


for (int x=1; x<=N;x++)
{
WriteLine($"{x*x*x}");

}

