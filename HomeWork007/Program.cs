Console.Clear();
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), 
// а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.
// Также, задайте метод PrintArray, который выводил бы массив на экран.
// Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) и 
// добавления символа табуляции (\t) после каждого элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.
// double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) 
// {   
//     double [,] array = new double [m, n];
//     for (int i = 0; i < array.GetLength(0);i++)
//     {
//         for (int j = 0; j < array.GetLength(1);j++)
//         {
//             array[i,j] = Math.Round(new Random().NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom, 2);
//         }
//     }
//     return array;
// }
// void PrintArray(double[, ] matrix) 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i,j]} \t");
//         Console.WriteLine();
//     }
// }
// int m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10;
// double [,] matrix = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
// PrintArray(matrix);

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, 
// на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу. 
// Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.
// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. 
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, 
// а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.
// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. 
// Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
// void PrintArray (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i,j]} \t");
//         Console.WriteLine();
//     }
// }
// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//     int [,] matrix = new int [n,m];
//     int number = 1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == 0 && j == 0) matrix[i, j] = 1;
//             else 
//             {
//                 number+=k;
//                 matrix[i, j] = number;
//             }
//         }
//     }
//     return matrix;
// }
// int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
// {  
//     if (matrix.GetLength(0) >= rowPosition && matrix.GetLength(1) >= columnPosition)
//     {
//         int [] array = new int [2];
//         array[0] = matrix[rowPosition, columnPosition];
//         array[1] = 0;
//         return array;
//     }
//     else 
//     {
//         int [] array = new int [1];
//         array[0] = 0;
//         return array;
//     }
// }
// void PrintCheckIfError (int[] results, int X, int Y)
// {
//     if (results.Length == 1) Console.WriteLine("There is no such index");
//     else Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
// }
// int [,] matrix = CreateIncreasingMatrix(4, 5, 3);
// PrintArray(matrix);
// Console.WriteLine($"{string.Join(",",FindNumberByPosition(matrix, 2, 2))}");
// int x = 2, y = 2;
// PrintCheckIfError(FindNumberByPosition(matrix, x, y), x, y);
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, 
// на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.
// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", 
// где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), 
// разделенные знаком табуляции.
// void PrintArray (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i,j]} \t");
//         Console.WriteLine();
//     }
// }
// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//     int [,] matrix = new int [n,m];
//     int number = 1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == 0 && j == 0) matrix[i, j] = 1;
//             else 
//             {
//                 number+=k;
//                 matrix[i, j] = number;
//             }
//         }
//     }
//     return matrix;
// }
// void PrintListAvr (double [] list)
// {
//     Console.WriteLine($"The averages in columns are:");
//     for (int i = 0; i < list.Length; i++)
//     {
//         Console.Write("{0:f}", list[i]);
//         Console.Write("\t");
//     }
// }
// double [] FindAverageInColumns (int [,] matrix)
// { 
//     double [] array = new double [matrix.GetLength(1)];
//     double temp = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             temp += Convert.ToDouble(matrix[j,i]);
//         }
//         array[i] = temp / matrix.GetLength(0);
//         temp = 0;
//     }
//     return array;
// }
// int [,] matrix = CreateIncreasingMatrix(3, 4, 2);
// PrintArray(matrix);
// PrintListAvr(FindAverageInColumns(matrix));