// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void BinaryNumber(int number)
{
    if(number <=0)
    {
        return;
    }
    BinaryNumber(number/2);
    System.Console.Write(number%2);
}

int number = DataЕntry("Enter a number");
BinaryNumber(number);