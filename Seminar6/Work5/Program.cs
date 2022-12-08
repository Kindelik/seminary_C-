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

int[] CopyArr(int[] array)
{
    int[] newArr = new int[array.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = array[i];
    }
    return newArr;
}

int size = 10;
int lRange = 0;
int rRange = 99;

int[] array1 = FillArray(size,lRange,rRange);
System.Console.WriteLine(string.Join(",", array1));

int[] array2 = CopyArr(array1);
System.Console.WriteLine(string.Join(",", array2));