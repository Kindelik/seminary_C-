int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int number1 = DataЕntry("Введите число 1");

int number2 = DataЕntry("Введите число 2");

int number3 = DataЕntry("Введите число 3");

int max = number1;

if ((number1 > number2) && (number1 > number3)) Console.WriteLine($"max number {number1}");
if ((number2 > number1) && (number2 > number3)) Console.WriteLine($"max number {number2}");