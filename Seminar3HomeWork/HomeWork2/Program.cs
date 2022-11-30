
int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();

int number = DataЕntry("Enter a five-digit number");

var array = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();

PrintArray(array);

Array.Reverse(array);

PrintArray(array);

int[] arrayReverse = new int[array.Length];

PrintArray(arrayReverse);

Array.Reverse(arrayReverse);

PrintArray(arrayReverse);