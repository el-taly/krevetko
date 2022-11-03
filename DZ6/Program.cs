// По 2-ум аданным числам проверить, является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Введите 1-ое число: ");
int numb=int.Parse(Console.ReadLine()!);
Console.WriteLine("Вы ввели число: " +numb);
Console.WriteLine("Введите 2-ое число: ");
int var=int.Parse(Console.ReadLine()!);
Console.WriteLine("Вы ввели число: " +var);

if(numb * numb ==var)
{
 Console.Write(var);
 Console.WriteLine (" квадрат " +numb); 
}
else

    if(var * var ==numb)
{
 Console.Write(numb);
 Console.WriteLine (" квадрат " +var); 
}

else
{
  Console.WriteLine("Фигня"); 
}
