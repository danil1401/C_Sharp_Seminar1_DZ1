Console.Clear();

/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void ZD64()
{
Console.Write ("Введиет значение N: ");
//int n=CorrectNaturalNumber();
int n=Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n);
PrintFromNTo1(n);
Console.WriteLine();
PrintFrom1ToN(n);
}

ZD64();

/////////////////////////////////////////////////////МЕТОДЫ//////////////////////////////////////////////////////////////////////////////////////////

void PrintFromNTo1(int number)// Рекурсия для печати от N до 1
{
    Console.Write($" {number} ");
    if (number ==1) return;
    else  PrintFromNTo1(number-1);
}
void PrintFrom1ToN(int number) // Рекурсия для печати от 1 до N
{
    if (number ==1) 
    {
        Console.Write($" {number} ");
        return;
    }
    else  
    {
        PrintFrom1ToN(number-1);
        Console.Write($" {number} ");
    }
}

