// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray(int number, int leftRange, int rigthRange)            //Метод - Создать рандомный массив c дробями и наполнить его
{
    Random rand = new Random();
    double[] collection = new double[number];
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(leftRange, rigthRange + 1) + new Random().NextDouble(); // Положить новое рандомное дробное число в индекс
        collection[index] = Math.Round(collection[index], 2);    // округляем значения в массиве до сотых долей
        index++;
    }
    return collection;
}



int size = 10;      // размер будущего массива
int leftRange = 0;    // левое ограничение рандома чисел в массиве
int rigthRange = 99;   // правое ограничение рандома чисел в массиве
double[] array = FillArray(size, leftRange, rigthRange);
System.Console.WriteLine("[" + string.Join(" , ", array) + "]");  // Вывод массива в терминал
double maxValue = array[0];
double minValue = array[0];
for (int i = 0; i < array.Length; i++)    // цикл поиска максимального и минимального значения в массиве
{
    if (maxValue < array[i])
    {
        maxValue = array[i];
    }
    if (minValue > array[i])
    {
        minValue = array[i];
    }
}
double difference = maxValue - minValue;
difference = Math.Round(difference,2); // правка бага с числами после запятой
System.Console.WriteLine($"Разница между максимальным и мининальным числами в массиве = {difference}");
