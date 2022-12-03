// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int NumberOfDigits(int numb)
{
    int i;
    if (numb < 0) numb = -numb;
    for (i = 0; numb > 0; i++)
    {
        numb = numb / 10;
    }
    return i;
}


int number = DataЕntry("Enter a number");
int count = NumberOfDigits(number);

Console.WriteLine(count);