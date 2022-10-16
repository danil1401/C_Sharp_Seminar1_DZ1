// Задача 25. Напишите цикл, который принимает на вход 2 числа А и В и возводит число А в натуральную степень В

Console.Clear();

Console.Write("Введите число A  : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int a_b = a;    //число, возведенное в степень
for(int i = 1; i < b; i++) 
{
   a_b = a_b * a;
}
Console.Write("число A в степени B = ");
Console.WriteLine(a_b);