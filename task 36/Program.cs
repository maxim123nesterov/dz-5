// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int n = 7;
int[] arr = new int[n];
int sum = 0;
for (int i = 0; i < n; i ++)
     {
        arr[i] = new Random().Next(-10, 10);
     Console.Write($" {arr[i]}");
        if (i % 2 == 1)
        sum = sum + arr[i];
     }
    
Console.WriteLine();
Console.Write($"сумма нечетных позиций = {sum}");
    