using System;

// Console.WriteLine(" Задача 1 ")
//
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

// Задача 2
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

// Задача 3
// Console.WriteLine(" Задача 3");

// Console.WriteLine(" Введите число");
// int a = int.Parse(Console.ReadLine());
// if(a % 2 == 0)
// {
//     Console.WriteLine("Число " + a + " Четное");
// }

// else
// {
//     Console.WriteLine("Число " + a + " Не четное");
// }

// Задача 4
Console.WriteLine("Задача 4");

Console.WriteLine("Укажите диапазон");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число кратности");
int b = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i <= a; i++ )
{
    if ( i % b == 0 )
    {
        Console.WriteLine("{0} ", i );
    }
}
