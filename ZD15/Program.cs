// Задача 15. Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

/*Console.WriteLine("Введите номер от 1 до 7: ");
int n=Convert.ToInt32(Console.ReadLine());

if (n==6| n==7)
{
    Console.WriteLine ("Сегодня Выходной ");
}

if (n==5)
{
    Console.WriteLine ("Каждую пятнциу я в ...)))");
}
else
{
    Console.WriteLine ("Выходные не за горами ;)");
}*/

Console.WriteLine("Введите номер от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7) // зацикливание для корректного ввода значения от 1го до 7ми
    {
        Console.WriteLine("Неделя состоит из 7ми дней, повторите ввод");
        n = Convert.ToInt32(Console.ReadLine());
    }
if (n == 6 || n == 7)
    {
    Console.WriteLine("Выходные-проведи их с пользой!");
    }

else Console.WriteLine("Рабочие будни. Выходные близко");