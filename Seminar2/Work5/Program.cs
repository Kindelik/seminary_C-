// 
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет
Console.Clear();
Console.WriteLine("Enter numberA");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter numberB");
int numberB = int.Parse(Console.ReadLine());

if ((numberA = numberB*numberB) || (numberB = numberA*numberA))
{
Console.WriteLine($" одно из чисел квадрат другого");
}
else
{
    Console.WriteLine($" одно число не является квадратом другого");
}