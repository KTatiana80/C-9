// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("N = " + number);

string str = Сountdown(number);
Console.Write(" -> \"" + str + "\"");

string Сountdown(int num)
{
    if (num == 1) return "" + num;
    return num + ", " + Сountdown(num - 1);
}