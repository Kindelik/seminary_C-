// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4



int[,] TwoDimArray(int rows, int columns, int leftRange, int rigthRange)
{

    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftRange, rigthRange + 1);
        }
    }
    return array;
}

void Qvadrat(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 2; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}

void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int m = 6;
int n = 6;
int leftRange = 0;
int rigthRange = 9;

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);
PrintTwoDimArray(array);
Qvadrat(array);
System.Console.WriteLine();
PrintTwoDimArray(array);

