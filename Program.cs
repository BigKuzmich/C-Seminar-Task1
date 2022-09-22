using System;

Console.WriteLine("Введите число 1");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b= int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max " + a);
}
else if (b > a)
{
    Console.WriteLine("max " + b);
}
else
{
    Console.WriteLine("Значения ровны");
}