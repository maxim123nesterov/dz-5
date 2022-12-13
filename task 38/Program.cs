// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int n = 5;
int[] arr = new int [n];
int max = 0;
int min = 10;

for (int i = 0; i < n; i ++)
{
    arr[i] = new Random().Next(0, 10);
    Console.Write($" {arr[i]}");
    
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
       min = arr[i];
    }
}
Console.WriteLine();
Console.Write($"Максимальное число - {max}");
Console.WriteLine();
Console.Write($"Минимальное число - {min}");
Console.WriteLine();
Console.Write($"Разница между min и max = {max - min}");