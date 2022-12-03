

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int number)            //Метод - Создать рандомный массив
{
    int[] collection = new int[number];
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2); // Положить новое рандомное число в индекс из диапозона 1-10
        index++;
    }
    return collection;
}


void PrintArray(int[] col)             //Метод - Вывести массив в терминал
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}


 int size = DataЕntry("Enter the length of the array");

int[] array = FillArray(size);

 PrintArray(array);
