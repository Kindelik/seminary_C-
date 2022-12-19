// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int DataEntry(string messag)
{
    System.Console.WriteLine(messag);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumNumber(int number)
{
    if (number < 10) return number;
    return SumNumber(number / 10) + number % 10;

}

int number = DataEntry("Введите число");
System.Console.WriteLine(SumNumber(number));

//SumNumber(DataEntry("Введите число"));