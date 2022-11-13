/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] MatrixOne = new int[n, m];
int[,] MatrixTwo = new int[n, m];
Console.WriteLine($"Начальные массивы: ");
InputMatrix(MatrixOne);
Console.WriteLine();
InputMatrix(MatrixTwo);

Console.WriteLine($"Конечный массив: ");
ReleaseMatrix(MatrixOne, MatrixTwo);

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] MatrixOne, int[,] MatrixTwo)
{
    Console.WriteLine();
    int[,] ResultMatrix = new int[MatrixOne.GetLength(0), MatrixOne.GetLength(1)];
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(0); j++)
        {
            ResultMatrix[i, j] = MatrixOne[i, j] * MatrixTwo[i, j];
            Console.Write(ResultMatrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

