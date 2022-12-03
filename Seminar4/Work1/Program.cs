// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int numb)
{
    //Пишем цикл от 1 до заданного числа
    //Суммируем каждый итератор
    int sum = 0;
    for (int i = 1; i <= numb; i++)
    {
        sum = sum + i;
    }
    return sum;
}

//Получить число от пользователя
int number = DataЕntry("Enter a number");


int result = FindSum(number);

Console.WriteLine($"The sum of the numbers up to = {result}");

