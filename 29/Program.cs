//Задача 29: Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.

int[] arr = CreateArray();
PrintArray(arr);

int[] CreateArray()
{
    int[] array = new int[8];
    int index = 0;
    while (index < 8)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}