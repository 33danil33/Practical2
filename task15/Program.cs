// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    System.Console.WriteLine("Ошибка");
}

if (number < 6)
{
    System.Console.WriteLine("нет, рабочий день");
}
else if (number > 5&& number <8)
{
    System.Console.WriteLine("да, выходной");
}