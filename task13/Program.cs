// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99 && number >= -99)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    System.Console.WriteLine(result);
}

