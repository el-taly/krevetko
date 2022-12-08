using System;
using static System.Console;

Clear();

Write("Введите число: ");
int numb=int.Parse(ReadLine());

int summ=0;
while(numb>0)
{
   summ=summ+numb%10;
   numb=numb/10;
}

WriteLine($"Сумма цифр в числе = {summ}");


