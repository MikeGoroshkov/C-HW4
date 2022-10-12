//Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа = {SumNumDigits(num)}");

int SumNumDigits(int number)
{
    if (number < 0) number = -number;
    int Sum = 0;
    while (number > 0)
    {
        Sum += number % 10;
        number /= 10;
    }
    return Sum;
}