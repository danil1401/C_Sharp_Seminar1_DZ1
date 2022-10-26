Console.Clear();
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет
*/

Console.Write ("Введите количество строк: ");
int n=CorrectNaturalNumber();
Console.Write ("Введите количество столбцов: ");
int m=CorrectNaturalNumber();
double [,] arrayOfDouble= new double[n,m];
FillWhithDouble(arrayOfDouble);
Console.WriteLine();
PrintArray(arrayOfDouble);
Console.WriteLine();
Console.WriteLine ("Введите номер значения ниже: ");

Console.Write ("Введите номер строки: ");
int line=CorrectNaturalNumber();
Console.Write ("Введиет номер столбца: ");
int column=CorrectNaturalNumber();
try
{
    Console.WriteLine($"Элемент [{line},{column}] является: {arrayOfDouble[line,column]:f4}");
}
catch
{
    Console.WriteLine($"Элемент [{line},{column}] не существует");
}


void FillWhithDouble(double[,] array)                               
{
    for (int i=0; i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1);j++)
        array[i,j]=new Random().NextDouble();
}

void PrintArray (double[,] array)                                   
{
    for (int i=0; i<array.GetLength(0);i++)
    
    {
        for (int j=0; j<array.GetLength(1);j++)
        Console.Write($"  {array[i,j]:f4}  ");
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