// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int max;

max=a;

if (b>max)max=b;
if (c>max)max=c;

Console.WriteLine("Максимальное число: "+max);


/*Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Max: " +a+ " Min: "+b );
}
if (c > b)
{
    Console.WriteLine("Max: " +c+ " Min: "+b );
}
else
{
    if (b > c)
    {
    Console.WriteLine("Max: " +b+ " Min: "+c );
    }
   
}*/

/*int Max(int a, int b, int c)
Console.WriteLine("Введите первое число ");
Console.WriteLine("Введите второе число ");
Console.WriteLine("Введите третье число ");
int result;
if(a>b) result =a max;
{
    Console.WriteLine("Max: a" );
}
if(b>c) result =b max;
{
    Console.WriteLine("Max: b" );
}
if(c>b) result =c max;
{
    Console.WriteLine("Max: c" );
}*/
    