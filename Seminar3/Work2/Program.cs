int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQuadrant(int a)                                      //Проверка на положительность коордитнат для вычисления квадранта           

{
    if (a == 1) Console.WriteLine("X > 0, Y > 0");                    // Квардранты плосткости начинается с x > 0, y > 0
    if (a == 2) Console.WriteLine("X < 0, Y > 0");
    if (a == 3) Console.WriteLine("X < 0, Y < 0");
    if (a == 4) Console.WriteLine("X > 0, Y < 0");

}


int quadrant = DataЕntry("Введите квадрант плоскости");

if ((quadrant > 0) && (quadrant < 5))

 {
    FindQuadrant(quadrant);
 }
else Console.WriteLine("The number is not correct");