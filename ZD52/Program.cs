Console.Clear();
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write ("Введите количество строк: ");
int n=CorrectNaturalNumber();
Console.Write ("Введите количество столбцов: ");
int m=CorrectNaturalNumber();
int [,] arrayOfInt= new int[n,m];
FillWhithDouble(arrayOfInt);
Console.WriteLine();
PrintArray(arrayOfInt);
Console.WriteLine();
Console.WriteLine ("Среднее арифметическое столбцов ");

for (int i=0; i<arrayOfInt.GetLength(0);i++)
{
    int summ=0;
    for (int j=0; j<arrayOfInt.GetLength(1);j++)
        summ+=arrayOfInt[j,i];

    Console.Write ($"  {Convert.ToDouble(summ)/n:f2}  ");
}

void FillWhithDouble(int[,] array)                              
{
    for (int i=0; i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1);j++)
        array[i,j]=new Random().Next(-100,100);
}

void PrintArray (int[,] array)                                 
{
    for (int i=0; i<array.GetLength(0);i++)
    
    {
        for (int j=0; j<array.GetLength(1);j++)
        Console.Write($"  {array[i,j]}  ");
        Console.WriteLine();
    }
}

int CorrectNaturalNumber()                                         
{
    string value="";
    int number=0;
    while (true)
    {
        value=Console.ReadLine();
        try 
        {
            number=int.Parse(value);
        }
        catch
        {
            Console.Write ("Повторите. Значение не является десятичным числом:: ");
            continue;
        }
        if (number<1) 
        {
            Console.Write ("Повторите. Значение меньше 1: ");
            continue;
        }
        return number;
    }
}