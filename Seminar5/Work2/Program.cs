// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int size = 10;
int leftRange = -9;
int rigthRange = 9;

int[] array = FillArray(size, leftRange, rigthRange);

System.Console.WriteLine('[' + string.Join(",", array) + ']');

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}

System.Console.WriteLine('[' + string.Join(",", array) + ']');