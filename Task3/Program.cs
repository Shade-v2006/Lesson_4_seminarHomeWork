/*
    Задача 3: Напишите программу, которая перевернёт одномерный массив 
    (первый элемент станет последним, второй – предпоследним и т.д.)
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

int[] SortSelection(int[] array)
{
    int n = array.Length; // длина массива
    int k = n / 2;          // середина массива
    int temp;               // вспомогательный элемент для обмена значениями
    for (int i = 0; i < k; i++)
    {
        temp = array[i];
        array[i] = array[n - i - 1];
        array[n - i - 1] = temp;
    }
    return array;
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

int[] array = GetRandomArray(7, 1, 100); // Передача в функцию аргументов
PrintArray(array); // Передача в функцию аргументов для печати
int[] array2 = SortSelection(array);
PrintArray(array2); // Передача в функцию аргументов для печати
