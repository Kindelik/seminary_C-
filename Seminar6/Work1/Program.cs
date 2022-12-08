

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

static void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


int size = 10;      // размер будущего массива
int leftRange = -99;    // левое ограничение рандома чисел в массиве
int rigthRange = 99;   // правое ограничение рандома чисел в массиве

int[] array = FillArray(size, leftRange, rigthRange);     // Создание массива через метод
System.Console.WriteLine("[" + string.Join(",", array) + "]");  // Вывод массива в терминал


