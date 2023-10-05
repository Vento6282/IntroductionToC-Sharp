Console.Clear();

// Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.
// int CountEvenElements(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//             count += 1;
//     return count;
// }
// void PrintArray(int[] array)
// {
//     Console.WriteLine($"{string.Join("\t", array)}\t");
// }

// int [] array = {100, 102, 105, 166, 283, 764, 300, 499, 133};
// PrintArray(array);
// Console.WriteLine(CountEvenElements(array));


// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// int SumOddElements(int[] array)
//     {
//         int summ = 0;
//         for (int i = 1; i < array.Length; i+=2)
//                 summ += array[i];
//         return summ;
//     }
// void PrintArray(int[] array)
// {
//     Console.WriteLine($"{string.Join("\t", array)}\t");
// }
// int [] array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
// PrintArray(array);
// Console.WriteLine(SumOddElements(array));


// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
// double FindMax(double[] array)
// {     // Введите свое решение ниже
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//         if (max < array[i]) max = array[i];
//     return Math.Round(max, 2);
// }
// double FindMin(double[] array)
// {     // Введите свое решение ниже
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//         if (min > array[i]) min = array[i];
//     return Math.Round(min, 2);
// }
// double CalcDifferenceBetweenMaxMin(double[] array)
// {// Введите свое решение ниже
//     double diff = 0;
//     diff = FindMax(array) - FindMin(array);
//     return Math.Round(diff, 2);
// }
// void PrintArray(double[] array)
// {// Введите свое решение ниже
//     Console.WriteLine($"{string.Join("\t", array)}\t");
// }
// double [] array = new double[] { 3, 7.4, 22.3, 2, 78 };
// Console.WriteLine(FindMax(array));
// Console.WriteLine(FindMin(array));
// Console.WriteLine(CalcDifferenceBetweenMaxMin(array));