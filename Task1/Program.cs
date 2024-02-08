/*
    Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
    Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/
// Условие: Взять число проверить его на четность

string GetArrayFrCons() // Функция чтения цифр из консоли
{
    Console.Write("Enter number: ");
    string size = (Console.ReadLine()!);
    return size;
}

int ParityCheck(string size) // Функция проверки нажатия "q" изменения массива в цифру и сложения цифр с проверкой на четность
{
    int num = 0;
    int sumNumber = 0;
    int sumNumber2 = 0;
    while (true)
    {


        if (size == "q")
        {
            System.Console.WriteLine("END!");
            break;
        }
        else
        {
            int digit = int.Parse(size);
            num = digit;
            int y = (int)Math.Log10(num) + 1; // Например, число 12345. Десятичный логарифм его равен примерно 4,091. Приводим к целому → 4. Плюс 1= 5. В числе 5 цифр.
            //System.Console.WriteLine(y);

            if (y == 1 && num % 2 == 0)
            {
                System.Console.WriteLine("Число четное!");
                break;
            }
            else
            {
                for (int i = 0; i < y; i++)
                {
                    sumNumber = num % 10;
                    num /= 10;
                    sumNumber2 += sumNumber;
                }
                if (sumNumber2 % 2 == 0)
                {
                    System.Console.WriteLine("Число четное! "+ sumNumber2);
                    break;
                }
                System.Console.WriteLine("Сумма цифр числа нечетная: " + sumNumber2);
                sumNumber = 0;
                sumNumber2 = 0;
                size = GetArrayFrCons();
            }
        }
    }
    return num;
}

string size = GetArrayFrCons();
int num = ParityCheck(size);



