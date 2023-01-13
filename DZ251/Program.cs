// Написать цикл, который на вход принимает 2 числа А и В и возводит число А в степень В
using System;
using static System.Console;

Clear();
int v = 1;

Write("Введите A: ");
int A=int.Parse(ReadLine());

Write("Введите B: ");
int B=int.Parse(ReadLine());

for(int i=1; i<=B; i++)
    {
        v=v*A;
    
    }
WriteLine(v);

