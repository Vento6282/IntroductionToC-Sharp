Console.Clear();
//-------------------------------------------------------------------------------------------------------------------------------------
// Реализуйте класс MatrixOperations, который содержит следующие статические методы:
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.
// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по убыванию.
// void FillMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i,j] = new Random().Next(10,100);
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i,j]}\t");
//         Console.WriteLine();
//     }
// }
// void SortRowsDescending(int[,] matrix)
// {  
//     int temp = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             for (int k = 1; k < matrix.GetLength(1); k++)
//             {
//                 if (matrix[i,k] > matrix[i,k-1]) 
//                 {
//                     temp = matrix[i,k];
//                     matrix[i,k] = matrix[i,k-1];
//                     matrix[i,k-1] = temp;
//                 }
//             }
//         }  
//     }  
// }
// int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int [,] matrix = new int [array[0],array[1]];
// FillMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// SortRowsDescending(matrix);
// PrintMatrix(matrix);
//-------------------------------------------------------------------------------------------------------------------------------------
// Реализуйте класс Answer, который содержит следующие статические методы:
// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
// Метод принимает двумерный массив целых чисел matrix и номер строки row, 
// а возвращает целое число - сумму элементов в данной строке.
// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.
void FillMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = new Random().Next(10,100);
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]}\t");
        Console.WriteLine();
    }
}
int SumOfRow(int[,] matrix, int row)
{   
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j ++)
    {
        sum += matrix[row,j];
    }
    return sum;
}
int[] MinimumSumRow(int[,] matrix)
{   
    int [] res = new int [2];
    int [] sumOfRow = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfRow[i] = SumOfRow(matrix, i);
        Console.WriteLine(sumOfRow[i]);
    } 
    res[0] = 0;
    res[1] = sumOfRow[0];
    for (int i = 1; i < sumOfRow.Length; i++)
    {
        if (sumOfRow[i] < res[0])
        {
            res[0] = i;
            res[1] = sumOfRow[i];
        }
    }
    return res;
}
int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [array[0],array[1]];
FillMatrix(matrix);
PrintMatrix(matrix);
int[] minSumRow = MinimumSumRow(matrix);
Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");



