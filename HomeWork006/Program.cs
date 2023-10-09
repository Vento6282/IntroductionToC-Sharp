Console.Clear();
void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int [] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}
int CountingPositiveNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) count += 1;
    }
    return count;
}
Console.WriteLine("Введите количество элементов:");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Положительных чисел - {CountingPositiveNumbers(array)}");