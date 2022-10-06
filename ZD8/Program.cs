// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

int N;
int i=1;
Console.WriteLine("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
    if (N % 2 == 0)
        Console.WriteLine(N);