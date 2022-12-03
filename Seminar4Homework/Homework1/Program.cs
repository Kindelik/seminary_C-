// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int[] numbers = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32(elem); });
    if (numbers.Length > 2) Console.WriteLine("The numbers фку incorrect");
    return numbers;
}

int NumbPow(int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}


//Решение
//Просим ввести два числа и отправляем их в массив
int[] twoNumbers = DataЕntry("Введите два числа через запятую");
// Используем метод (в котором использован цикл) для вычислений
int numberPow = NumbPow(twoNumbers[0], twoNumbers[1]);
//Выводим результат в терминал
Console.WriteLine($"Number {twoNumbers[0]} to the power of {twoNumbers[1]} = {numberPow}");



