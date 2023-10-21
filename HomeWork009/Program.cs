Console.Clear();
//----------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// string rec(int numberA, int numberB)
// {
//     if(numberA == numberB)
//         return $"{numberA} ";
//     return rec(numberA, numberB + 1) + $"{numberB} ";
// }
// Console.WriteLine("Введите число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(numberA, 1));
//----------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int rec(int numberA, int numberB)
// {
//     if (numberA == numberB)
//         return numberA;
//     return rec(numberA, numberB - 1) + numberB;
// }
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(numberA, numberB));
//----------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// int Akkerman(int numberA, int numberB)
// {
//     if (numberA == 0) return numberB + 1;
//     if (numberA > 0 && numberB == 0) return Akkerman(numberA - 1, 1);
//     return Akkerman(numberA - 1, Akkerman(numberA, numberB - 1));
// }
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Akkerman(numberA, numberB));