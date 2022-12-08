// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int[] ConvertToFib(int number)
{
    int[] arrFib = new int[number];
    arrFib[0] = 0;
    arrFib[1] = 1;
    for (int i = 2; i < arrFib.Length; i++)
    {
        arrFib[i] = arrFib[i-2]+arrFib[i-1];
    }
    return arrFib;
}

int number = DataЕntry("Enter a number");

int[] fibNumber = ConvertToFib(number);
System.Console.WriteLine(string.Join(",",fibNumber ));