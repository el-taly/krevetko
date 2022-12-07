// в 3D задать координаты 2-ух точек и найти расстояние между ними

using System;
using static System.Console;

Clear();

Write("Введите А1: ");
int a1=int.Parse(ReadLine());

Write("Введите А2: ");
int a2=int.Parse(ReadLine());

Write("Введите А3: ");
int a3=int.Parse(ReadLine());

Write("Введите B1: ");
int b1=int.Parse(ReadLine());

Write("Введите B2: ");
int b2=int.Parse(ReadLine());

Write("Введите B3: ");
int b3=int.Parse(ReadLine());

double AB=Math.Sqrt((Math.Pow(a1-b1,2))+(Math.Pow(a2-b2,2))+(Math.Pow(a3-b3,2)));

WriteLine($"Расстояние между точками А и В = {AB}");

