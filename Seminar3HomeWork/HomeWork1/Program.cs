﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


Console.Clear();

int number = DataЕntry("Enter a five-digit number");

if ((number > 9999) && (number < 100000))
{
    var array = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
    int[] arrayReverse = new int[array.Length];
    Array.Copy(array, arrayReverse, array.Length);
    Array.Reverse(arrayReverse);

    int i = array.Length - 1;
    if (array[i] == arrayReverse[i])          //Решение херня, но не смог придумать лучше
    {
        i--;
        if (array[i] == arrayReverse[i])
        {
            i--;
            if (array[i] == arrayReverse[i])
            {
                i--;
                if (array[i] == arrayReverse[i])
                {
                    i--;
                    if (array[i] == arrayReverse[i])
                    {
                        Console.WriteLine("This is number a palindrome ");
                    }

                }


            }
        }
    }
    else Console.WriteLine("This is number not a palindrome ");
}
else Console.WriteLine("The number is not correct");























