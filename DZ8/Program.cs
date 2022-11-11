//Найти расстояние между точками в пространстве 2D/ 3D

Console.Clear();
Console.WriteLine("Введите первую координату точки1: x1: ");
int x1=int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите вторую координату точки1: y1: ");
int y1=int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите первую координату точки2: x2: ");
int x2=int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите вторую координату точки2: y2: ");
int y2=int.Parse(Console.ReadLine()?? "0");
double d;
int a=x2-x1;
int b=y1-y2;
int c=a*a+b*b;

d=Math.Sqrt(c);
Console.WriteLine("Растояние между точками равно: " +d);

