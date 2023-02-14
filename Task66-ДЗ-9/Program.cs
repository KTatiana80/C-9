
// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumNaturalElements(int num1, int num2)
{
    if (num1 == num2) return num2;
    return SumNaturalElements(num1 + 1, num2) +num1;
}

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 < 0 || number1 < 0)
{
    Console.WriteLine("Введено не натуральное число");
    return;
}

int sum = SumNaturalElements(number1, number2);
Console.WriteLine("Сумма = " + sum);
