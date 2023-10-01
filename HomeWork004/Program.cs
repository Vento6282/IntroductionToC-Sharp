Console.Clear();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// int f(int number, int power)
// {
//     int res = 1;
//     for (int i = 1;i <= power; i++)
//         res *=number;
//     return res;
// }
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень:");
// int power = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(number, power));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// void f(int number)
// {
//     int res = 0;
//     if (number < 0) number = number * (-1);
//     while (number > 0)
//     {
//         res += (number % 10);
//         number /= 10;
//     }
//     Console.WriteLine(res);
// }
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// f(number);

// Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]
// void fillArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"Введите элемент массива №{i+1}:");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// void printArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// Console.WriteLine("Введите длину массива:");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[number];
// fillArray(array);
// printArray(array);
