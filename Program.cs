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
Console.WriteLine();


/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

int Task66(int M, int N)
{
    if (N == M)
        return N;
    return M + Task66(M+1, N);
}

Console.WriteLine("ЗАДАЧА 66");
Console.Write("Введите концы промежутка натуральных числел M и N через пробел ");
string[] inputdata = Console.ReadLine().Split();
int a = int.Parse(inputdata[0]);
int b = int.Parse(inputdata[1]);
int s = Task66(a,b);
Console.Write("сумму натуральных чисел в промежутке от " + a + " до " + b + " равна " + s);





