/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void Task64(int N)
{
    if (N == 0)
        Console.WriteLine();
    else
    {
        Console.Write(N + " ");
        Task64(N-1);
    }
}

Console.WriteLine("ЗАДАЧА 64");
Console.Write("Введите натуральное число N ");
int n = int.Parse(Console.ReadLine());
Task64(n);