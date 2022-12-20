// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DataEntry(string messag)
{
    System.Console.WriteLine(messag);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumNumber(int number, int power)
{
    if (power < 2) return ;
    return SumNumber(number, power- 1)*number;

}

int number = DataEntry("Введите число");
int power = DataEntry("Введите степень");
System.Console.WriteLine(SumNumber(number, power));

//SumNumber(DataEntry("Введите число"));