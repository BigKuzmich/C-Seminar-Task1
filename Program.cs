using System;

// Console.WriteLine("Введите число 1");
// int a= int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int b= int.Parse(Console.ReadLine());
// if (a > b)
// {
//     Console.WriteLine("max " + a);
// }
// else if (b > a)
// {
//     Console.WriteLine("max " + b);
// }
// else
// {
//     Console.WriteLine("Значения ровны");
// }

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Задача 2");

//         Console.WriteLine("Введите число 1");
//         int a = int.Parse(Console.ReadLine());
//         Console.WriteLine("Введите число 2");
//         int b = int.Parse(Console.ReadLine());
//         Console.WriteLine("Введите число 3");
//         int c = int.Parse(Console.ReadLine());
//         if (c < a && a > b)
//         {
//             Console.WriteLine("max " + a);
//         }
//         else if (c < b && b > a)
//         {
//             Console.WriteLine("max " + b);
//         }
//         else if (a < c && c > b)
//         {
//             Console.WriteLine("max " + c);
//         }
//     }
// }

Console.WriteLine(" Задача 3");

Console.WriteLine(" Введите число");
int a = int.Parse(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine("Число " + a + " Четное");
}

else
{
    Console.WriteLine("Число " + a + " Не четное");
}
