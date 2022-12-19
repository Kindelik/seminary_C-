// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NumberPlus(int number, int count)
{
    if(count <= number)
    {
        System.Console.WriteLine(count);
        count++;
        NumberPlus(number, count);
        
    }

}

int number = 10;
int count = 1;

NumberPlus(number,count);