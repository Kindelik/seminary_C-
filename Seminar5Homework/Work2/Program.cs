// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int size = 10;      // размер будущего массива
int leftRange = -99;    // левое ограничение рандома чисел в массиве
int rigthRange = 99;   // правое ограничение рандома чисел в массиве

int[] array = FillArray(size, leftRange, rigthRange);     // Создание массива через метод
System.Console.WriteLine("[" + string.Join(",", array) + "]");  // Вывод массива в терминал
int sumOfOdd = 0;      // Значение для подсчета суммы элементов под нечетным индесом
for (int i = 0; i < array.Length; i++)  // цикл для суммирования значений с нечетным индексом
{
    if (i % 2 != 0)    // пытался в for написать(i=1, i < array.Length, i + 2) и делать без if, но неработает
    {
        sumOfOdd = sumOfOdd + array[i];
    }
}
System.Console.WriteLine($"Сумма нечетных индексов массива = {sumOfOdd}");