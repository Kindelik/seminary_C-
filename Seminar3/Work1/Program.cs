
Console.Clear();

int DataЕntryXY(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQuadrant(int a, int b)                                      //Проверка на положительность коордитнат для вычисления квадранта           

{
    if ((a > 0) && (b > 0)) Console.WriteLine("Quadrant = 1");
    if ((a < 0) && (b > 0)) Console.WriteLine("Quadrant = 2");
    if ((a < 0) && (b < 0)) Console.WriteLine("Quadrant = 3");
    if ((a > 0) && (b < 0)) Console.WriteLine("Quadrant = 4");

}



int x = DataЕntryXY("Введите координату X");
//Console.WriteLine(x);

int y = DataЕntryXY("Введите координату Y");
//Console.WriteLine(y);

FindQuadrant(x, y);