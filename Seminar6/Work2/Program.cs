// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Treug(int a, int b, int c)
{
    if ((a<b+c)&&(b<a+c)&&(c<a+b))
    {
        System.Console.WriteLine("Эти числа могут быть сторонами треугольника");
    }
    else
{
    System.Console.WriteLine(" Эти числа не могут быть сторонами треугольника");
}
}

int a = DataЕntry("enter a number 'a'");
int b = DataЕntry("enter a number 'b'");
int c = DataЕntry("enter a number 'c'");

Treug(a,b,c);