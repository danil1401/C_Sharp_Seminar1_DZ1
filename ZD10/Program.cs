﻿//Задача 10. Написать программу которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
//Задача 13. Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Задача 15. Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

int N =0;
Console.WriteLine("Введите трехзначное число: ");
N=Convert.ToInt32(Console.ReadLine());

if (N >=100 && N<=999)// проверка числа на 3х значность
{
    int DecreaseByTen=N/10;// делим число на 10
    int LastDigit=DecreaseByTen %10;// берем пследнюю цифру(не остаток) от числа поделенного на 10
    Console.WriteLine("Вторая цифра числа N = "+ LastDigit);// выводим эту последнюю цифру, которая и обозначает вторую чифру вводимого 3х значного числа
}

else
{
    Console.WriteLine("Число не является 3х значным, повторите ввод! ");

}