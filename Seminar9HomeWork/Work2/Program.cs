// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int DataEntry(string messag)
{
    System.Console.Write($"{messag} => ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void SumNumbers (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"The sum of natural elements in the range from M to N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNumbers(numberM, numberN, sum);
}

int numberM = DataEntry("Enter first number");
int numberN = DataEntry("Enter second number");
if (numberM < numberN)
{
    SumNumbers(numberM, numberN, 0);
}
if (numberM > numberN)
{
    System.Console.WriteLine("ERROR => The first number must be less than the second number ");
}
