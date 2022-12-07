// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int size = 9;
int leftRange = 0;
int rigthRange = 100;

int[] array = FillArray(size, leftRange, rigthRange);

int[] array2 = new int[size / 2 + size % 2];

for (int i = 0; i < size / 2; i++)
{
    array2[i] = array[i] * array[array.Length - 1 - i];
}

if (array.Length % 2 != 0)
{
    array2[array2.Length - 1] = array[array.Length / 2];
}
System.Console.WriteLine("[" + string.Join(",", array) + "]");
System.Console.WriteLine("[" + string.Join(",", array2) + "]");