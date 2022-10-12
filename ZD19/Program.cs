//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();


int Prompt(string message)
{
 System.Console.Write(message);
 string readValue = Console.ReadLine(); 
 int result = int.Parse(readValue); 
 return result; 
}
 
int N = Prompt("Введите 5ти значное число: ");
void Palindrome(int N)
{
 if (N > 10000 && N < 100000)
 {
 int number1 = N / 10000;
 int number5 = N % 10;
 if (number1 == number5)
 {
 int number2 = N / 1000 % 10;
 int number4 = N / 10 % 10;
 if (number2 == number4)
 {
 System.Console.WriteLine("Палиндром");
 }
 else
 System.Console.WriteLine("Не палиндром");
 }
 else
 System.Console.WriteLine("Не палиндром");
 }
 else
 {
 System.Console.WriteLine("Введено не корректное значение- повторите попытку");
 
 }
}
 
Palindrome(N);