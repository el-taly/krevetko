//Программа, которая принимает на вход число и показывает 3-ю цифру или
//сообщает, что ее нет

Console.Clear();
Console.WriteLine("Введите число: ");
int numb=int.Parse(Console.ReadLine()?? "0");
if (numb>1 && numb<100)
Console.WriteLine("У числа нет третьей цифры");
else
{
    while (numb>1000)
    {
     numb=numb/10;
     
 
    }
    int ost=numb%10;

Console.WriteLine("Третья цифра числа =: " +ost);
}

