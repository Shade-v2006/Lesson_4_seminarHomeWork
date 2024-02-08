/*
    Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int[] GetRandomArray(int size, int minValue, int maxValue) //  Функция для создания рандомного массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1); // Добавляем 1 для того чтоб было именно до 100
    }
    return array;
}

int SortSelection(int[] array) //  Функция для проверки четных элементов массива
{
    int result = 0;
    foreach (var elem in array)
    {
        if (elem % 2 == 0)
        {
            result++;
        }
    }
    return result;
}
void PrintArray(int[] array) //  Функция для вывода текста на экран
{
    Console.Write("[");
    foreach (int namber in array)
    {
        Console.Write(namber + " ");
    }
    Console.WriteLine("]");
}

int[] array = GetRandomArray(10, 100, 999); // Передача в функцию аргументов
PrintArray(array); // Передача в функцию аргументов для печати
int result = SortSelection(array);
System.Console.WriteLine($"Количество четных элементов в массиве: {(result)}"); // Передача в функцию аргументов для печати