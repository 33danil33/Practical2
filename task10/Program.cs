// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.WriteLine("Введите трёхзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 <= 100 && number1 >= 999) 
{
    Console.WriteLine("Число не трёхзначное");
}
else if (number1 >= 100 && number1 <= 999)
{
    int N = number1 % 100 / 10;
    Console.WriteLine("" + N);
}