Console.Clear();

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double Qvdrat(int a)
{
    double b = Math.Pow(a, 2);
    // int b = (a*a);

    return (b);
}

int x = DataЕntry("Введите число");
//for (i = 1, i++, i<x)

int count = 1;
double[] array = new double[] { };
while (count <= x)
{
    double a = Qvdrat(count);
    array = array.Concat(new double[] { a }).ToArray();
    count++;
}
Console.WriteLine(String.Join(", ", array));