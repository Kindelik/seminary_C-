// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

int size = 123;
int leftRange = 0;
int rigthRange = 500;

int[] array = FillArray(size, leftRange, rigthRange);

int count =0;

for (int i = 0; i < array.Length; i++)
{
    if ((array[i] > 9) && (array[i] < 100))
    {
        count++;
    }
}

System.Console.WriteLine($"количество чисел от 10 до 99 = {count}");