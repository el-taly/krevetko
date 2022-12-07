// На вход подается пятизначное число, проверить является ли оно палиндромом

using System;
using static System.Console;

Clear();

Write("Введите Пятизначное число: ");
int numb=int.Parse(ReadLine());

if (numb<10000 || numb>99999)
{
WriteLine("Это не пятизначное число");
}
else
{

    int a=numb/10000;
     WriteLine($"{a}"); 
    int b=numb%10;
     WriteLine($"{b}"); 
     int c=(numb/1000)%10;
     WriteLine($"{c}"); 
     int d=(numb%100)/10;
     WriteLine($"{d}"); 
   if (a==b && c==d)
   {
WriteLine($"Это палиндром");

   }
 else
 {
   WriteLine($"Это не палиндром"); 
 }
}
