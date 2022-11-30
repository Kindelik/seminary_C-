// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double InCube(int a)
{
    double b = Math.Pow(a, 3);
    // int b = (a*a);

    return (b);
}

int number = DataЕntry("Введите число");

double[] array = new double[] { };
for (int i = 1; i <= number; i++)
{
    double x = InCube(i);
    array = array.Concat(new double[] { x }).ToArray();
}
Console.WriteLine(String.Join(", ", array));