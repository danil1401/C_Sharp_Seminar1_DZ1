//Задача 13. Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

/*Console.WriteLine("Введите число N (без остатка): ");
int N = int.Parse(Console.ReadLine());
N = Math.Abs(N);

if (N >= 100)
{
    if (N > 999)// Елсли не 3х значное делаем ниже
        {
        int i = 10;
        while (N / i > 1000)
            { 
                i = i * 10; 
            }
        Console.WriteLine("Третья цифра числа N:" + (N / i) % 10);
        }
    else
        {
        Console.WriteLine("Третья цифра числа N:" + N % 10);
        }
}
else
{
    Console.WriteLine("В веденом числе N нет третьей цифры");
}*/


//Альтернативное решение
Console.WriteLine("Введите число N (без остатка): ");
int N = Convert.ToInt32(Console.ReadLine());
string N_text = Convert.ToString(N);
if(N_text.Length>2) // Если введенная цифра больше 2х, то будет 3ая цифра
    {
        Console.WriteLine("Третья цифра числа N: "+N_text[2]); // [2]-указан индекс 3ей цифры которая и будет браться в вывод
    }
else
    {  
         Console.WriteLine("Третья цифра числа N отсутсвует");
    }

