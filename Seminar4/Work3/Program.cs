int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindPr(int numb)
{
    //Пишем цикл от 1 до заданного числа
    //Перемножаем каждый итератор
    int pr = 1;
    for (int i = 1; i <= numb; i++)
    {
        pr = pr * i;
    }
    return pr;
}

//Получить число от пользователя
int number = DataЕntry("Enter a number");


int result = FindPr(number);

Console.WriteLine($"The product of the numbers up to = {result}");