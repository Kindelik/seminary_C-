// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfDigits(int numb)
{
    if (numb<0) numb = -numb;
    int result = 0;
    for (int i = 0; numb != 0; i++)
    {
        result = result + numb%10;
        numb = numb/10;
    }
    return result;
}

//Решение
//Предлагаем ввести число
int number = DataЕntry("Enter a number");
//Используем метод для вычисления суммы цифр в числе
int sum = SumOfDigits(number);
// Выводим полученный результат в терминал
Console.WriteLine($"Sum of the digits of the number {number} = {sum}");
