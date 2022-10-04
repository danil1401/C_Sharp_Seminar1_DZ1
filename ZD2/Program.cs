Console.Clear();

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Max: " +a+ " Min: "+b );
}
else
{
    if (b > a)
    {
    Console.WriteLine("Max: " +b+ " Min: "+a );
    }

}

/*Console.Write("Введите первое число: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
int max = n;
if (max < m)
    max = m;
Console.WriteLine (max);*/