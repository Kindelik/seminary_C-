// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.





Console.Clear();

int RandomDigit = new Random().Next(10, 100);
Console.WriteLine($"random number {RandomDigit}");

int numberA = RandomDigit / 10;
int numberB = RandomDigit % 10;

if (numberA > numberB)   //находим какая цифра больше
{
    Console.WriteLine(numberA);
}
else
{
    Console.WriteLine(numberB);
}