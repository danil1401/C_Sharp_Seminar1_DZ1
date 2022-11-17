Console.Clear();

/*Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void ZD66()
{
    Console.Write("Введите значение М: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(($"Cумма натуральных элементов в промежутке от {m} до {n} = {ResultNumbers(m, n)}"));  
    
    int ResultNumbers(int m, int n)
        {
            if (n == m) return n;

            return n + ResultNumbers(m, n - 1);

        }

}

ZD66();