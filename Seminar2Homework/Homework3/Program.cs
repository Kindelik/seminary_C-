// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
int[] Day = { 1, 2, 3, 4, 5, 6, 7 };
//int count = Day.Length;
int index = 0;
Console.WriteLine("Enter the number indicating the day of the week"); //Введите цифру обозначающую день недели
int numberDay = Convert.ToInt32(Console.ReadLine());
if ((numberDay > 0) & (numberDay < Day.Length + 1))      // проверка на корректность введенного числа

// Вообще задача решается просто через If (numberDay == 6) || (numberDay == 7) 
// массив тут не нужен
{
    while (numberDay != Day[index])
    {
        index++;
    }
    if (index < 5)
    {
        Console.WriteLine("Working day");
    }
    else Console.WriteLine("Weekend");
}
else Console.WriteLine("The number is not correct");
