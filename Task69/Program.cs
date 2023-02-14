// Задача 69:
// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.

// А = 3; В = 5 -> 243 (3 в 5степени)
// А = 2; В = 3 -> 8

int SumDigits(int num1, int num2)
{
    if (num2==0) return 1;
    return num1 * SumDigits(num1, num2 - 1);
    // Либо так
    // return num2 == 0 ? 1 : num1 * SumDigits(num1, num2 -1);
}

Console.Write("Введите число А :");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В :");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int numberOneAExtentNumberTwo = SumDigits(numberOne,numberTwo);
Console.WriteLine(numberOneAExtentNumberTwo);