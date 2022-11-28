//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Примеры
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 2;
int[] array = new int[] {};
if (number > 0)
{
    while (count <= number)
    {
        
        array = array.Concat(new int[] { count }).ToArray();
        count = count + 2;

    }
 Console.WriteLine(String.Join(",",array));
}

// задача выполнена

// все следующее написано, если введеное число будет отрицательным
else
{
    count = 0;
    while (count >= number)
    {
        Console.Write($"{count},");
        count = count - 2;
    }
}