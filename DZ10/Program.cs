//Программа, которая принимает на вход 3-ех значное число и показывает вторую цифру
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int numb=int.Parse(Console.ReadLine()?? "0");
int key=numb/10;
Console.WriteLine("Частное от деления трехзначного числа на 10 =: " +key);
int ost=key%10;
Console.WriteLine("Вторая цифра трехзначного числа =: " +ost);