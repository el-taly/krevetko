Console.Clear();
Console.WriteLine("Введите число дня недели от 1 до 7: ");
int numb=int.Parse(Console.ReadLine()!);
Console.WriteLine("Вы ввели число дня недели, " +numb);

if(numb == 6 || numb==7)
{
 Console.WriteLine("Выходной"); 
}
else
{
  Console.WriteLine("Будний день"); 
}
