//Задача 2: Напишите программу, которая на вход принимает два 
//числа и выдаёт, какое число большее, а какое меньшее.

// Console.Clear();
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA > numberB)
// {
//     Console.WriteLine("Максимум - " + numberA);
//     Console.WriteLine("Минимум - " + numberB);
// }
// else if (numberA < numberB)
// {
//     Console.WriteLine("Max - " + numberB);
//     Console.WriteLine("Min - " + numberA);
// }
// else
//     Console.WriteLine("Числа равны!");

//----------------------------------------------------------------------------
//Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

// Console.Clear();
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int numberC = Convert.ToInt32(Console.ReadLine());
// if ((numberA >= numberB) && (numberA >= numberC))
//     Console.WriteLine("Максимальное число: " + numberA);
// else if ((numberB >= numberA) && (numberB >= numberC))
//     Console.WriteLine("Максимальное число: " + numberB);
// else 
//     Console.WriteLine("Максимальное число: " + numberC);

//----------------------------------------------------------------------------
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// Console.Clear();
// Console.WriteLine("Введите число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if (numberA % 2 ==0)
//     Console.WriteLine("Число " + numberA + " чётное");
// else
//     Console.WriteLine("Число " + numberA + " нечётное");

//----------------------------------------------------------------------------
//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// Console.Clear();
// Console.WriteLine("Введите число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <= numberA; i+=2)
//     Console.Write ( i + " ");