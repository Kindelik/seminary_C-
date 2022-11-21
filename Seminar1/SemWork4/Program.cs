//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"


Console.Clear();
Console.Write("введите число N - ");
int numberA = int.Parse(Console.ReadLine());
int count = 0;
if (numberA > 0)
{
    count = -numberA;
    while (count < numberA + 1)
    {
        Console.Write($"{count}, ");
        count++;
    }
}
else
{
    count = numberA;
     while (count < -numberA + 1 )
    {
        Console.Write($"{count}, ");
        count++;
    }
}