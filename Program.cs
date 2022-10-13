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
Console.WriteLine("сумма натуральных чисел в промежутке от " + a + " до " + b + " равна " + s);
Console.WriteLine();


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/

int Task68(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Task68(m-1,1);
    return Task68(m-1,Task68(m,n-1));
}

Console.WriteLine("ЗАДАЧА 68");
Console.Write("Введите два неотрицательных числа m и n через пробел ");
string[] data = Console.ReadLine().Split();
int x = int.Parse(data[0]);
int y = int.Parse(data[1]);
int akk = Task68(x,y);
Console.WriteLine("A(" + x + ", " + y + ") = " + akk);
Console.WriteLine();




