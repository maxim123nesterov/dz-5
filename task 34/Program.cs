//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int n = 5;
int[] arr = new int[n];
int i = 0;
int count = 0;

    for (i = 0; i < n; i++)
    {    
    arr[i] = new Random().Next(100, 1000);
    Console.Write($" {arr[i]}");
         if (arr[i] % 2 == 0)
        {
           count =  count + 1;  
        }
    }
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел = {count}");

