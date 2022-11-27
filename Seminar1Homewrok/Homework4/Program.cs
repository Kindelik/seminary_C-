//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Примеры
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 2;
if (number > 0)
{
    while  (count <= number )
    {
        Console.Write($"{count},");
        count = count + 2;
    }
}
// задача выполнена

// все следующее написано, если введеное число будет отрицательным
else
{
    count = 0;
    while (count >= number)
    {
        Console.Write($"{count},");
        count = count -2;
    }
}