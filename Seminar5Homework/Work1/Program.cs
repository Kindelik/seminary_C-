// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int number, int leftRange, int rigthRange)            //Метод - Создать рандомный массив и наполнить его
{
    int[] collection = new int[number];
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(leftRange, rigthRange + 1); // Положить новое рандомное число в индекс из диапозона 1-10
        index++;
    }
    return collection;
}

int size = 50;      // размер будущего массива
int leftRange = 100;    // левое ограничение рандома чисел в массиве
int rigthRange = 999;   // правое ограничение рандома чисел в массиве

int[] array = FillArray(size, leftRange, rigthRange);     // Создание массива через метод
System.Console.WriteLine("[" + string.Join(",", array) + "]");  // Вывод массива в терминал
int evenNumbers = 0;      // счетчик для подсчета четных чисел в массиве
for (int i = 0; i < array.Length; i++)  // цикл для подсчета
{
    if (array[i] % 2 == 0)
    {
        evenNumbers++;
    }
}
System.Console.WriteLine($"Количетсво четных чисел в массиве = {evenNumbers}"); //вывод искомого в терминал