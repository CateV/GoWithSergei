// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//if(a*a == b)
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да
//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого
Console.WriteLine ("Введите первое число");
String number = Console.ReadLine();
int b = Convert.ToInt32(number);
Console.WriteLine ("Введите второе число");
String number1 = Console.ReadLine();
int c = Convert.ToInt32(number1);
if(b*b == c)
{
System.Console.WriteLine($"число {c} является квадратом {b}");
}
else System.Console.WriteLine($"число {c} не является квадратом {b}");




