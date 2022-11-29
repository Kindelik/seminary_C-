// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


double LengthBetweenPoints(int a1, int b1, int a2, int b2)                // Метод для вычисления расстояния между координатами
{
    double Distance = Math.Sqrt(Math.Pow(a2 - a1, 2) + (b2 - b1) * (b2 - b1));        // Sart - Квадратный корень. Pow - возведение в степень которая после ,
    return Distance;
}


int x1 = DataЕntry("Введите x1");
int y1 = DataЕntry("Введите y1");
int x2 = DataЕntry("Введите x2");
int y2 = DataЕntry("Введите y2");

double rast = LengthBetweenPoints(x1, y1, x2, y2);                // не путай очередность НИКОГДА
Console.WriteLine(rast);                                      // можно не создавать переменную а сразу вывести функцию в ответ
