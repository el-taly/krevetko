//задать номер четверти, показать диапазон возможных
//координат

Console.Clear();
Console.WriteLine("Введите первую координату четверти: ");
int x=int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите вторую координату четверти: ");
int Y=int.Parse(Console.ReadLine()?? "0");
if(x>0 && Y>0)
{
Console.WriteLine("Первая четверть: ");
}

if(x<0 && Y>0)
{
Console.WriteLine("Вторая четверть: ");
}
if(x<0 && Y<0)
{
Console.WriteLine("Третья четверть: ");
}
if(x>0 && Y<0)
{
Console.WriteLine("Чтвертая четверть: ");
}
