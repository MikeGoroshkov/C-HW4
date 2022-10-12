//Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} = {RaiseToPower(a, b)}");

int RaiseToPower(int number, int power)
{
    int i = 0;
    int result = 1;
    while (i < power)
    {
        result *= number;
        i++;
    }
    return result;
}
