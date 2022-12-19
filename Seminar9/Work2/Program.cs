// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, ?, 6, 7, 8"

int number = 10;
int count = 4;

void NumberPlus(int number, int count)
{
    if(count <= number)
    {
        System.Console.WriteLine(count);
        count++;
        NumberPlus(number, count);
        
    }

}

NumberPlus(number,count);