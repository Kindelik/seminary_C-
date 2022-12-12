// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double pointX;
double pointY;

Console.WriteLine("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");

int b1 = DataЕntry("Введите значение b1");
int k1 = DataЕntry("Введите значение k1");
int b2 = DataЕntry("Введите значение b2");
int k2 = DataЕntry("Введите значение k2");

if (k1 == b1)
{
    Console.WriteLine("Прямые c такими параметрами паралельны");
}
else
{
    pointX = (double)(b2 - b1) / (k1 - k2);
    pointY = (double)k1 * (b2 - b1) / (k1 - k2) + b1;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х = {pointX}");
    Console.WriteLine($"Y = {pointY}");
}
