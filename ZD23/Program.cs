//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= n; i++)
Console.WriteLine($" {i * i * i} ");


/*Только куб введеного числа
Console.Write("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write($" {i * i * i} ");*/