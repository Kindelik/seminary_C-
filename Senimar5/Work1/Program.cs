// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.



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



System.Console.Clear();

const int lengthArray = 12;
const int leftRange = -9;
const int rigthRange = 9;

int[] array = FillArray(lengthArray, leftRange, rigthRange);
System.Console.WriteLine('[' + string.Join(",", array) + ']');



int sumPozitiv = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPozitiv += array[i];
    }
    else
    {
        sumNegative += array[i];

    }
}

Console.WriteLine($"sum positiv = {sumPozitiv} , sum negativ = {sumNegative}");