// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] FillArray(int number , int leftRange, int rigthRange)            //Метод - Создать рандомный массив и наполнить его
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
int leftRange = 0;
int rigthRange = 999;

int[] array = FillArray(size, leftRange, rigthRange);

System.Console.WriteLine('[' + string.Join(",", array) + ']');

System.Console.WriteLine("Enter a number = ");
int number = int.Parse(Console.ReadLine());
bool result = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        result = true;
        break;
    }
}
if (result)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}