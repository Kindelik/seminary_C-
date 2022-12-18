// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintTwoDimArray(int[,] array)  // метод вывода двумерного массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}");
            if (j < array.GetLength(1) - 1) System.Console.Write(" ; ");
        }
        System.Console.Write("]");
        System.Console.WriteLine();
    }
}

int[,] TwoDimArray(int rows, int columns, int leftRange, int rigthRange)  // Метод для создания двумерного массива и заполнение его рандомными значениями
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

void RowSmallerSum(int[,] array)    // метод поиска строки с наименьшей суммой
{
    int[] arrSum = new int[array.GetLength(0)];      // для записи сумм строк массива
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrSum[i] += array[i, j];
        }
    }
 // System.Console.WriteLine("\n" + string.Join(" ; ", arrSum));    // для проверки правильности работы
    int temp = arrSum[0];       // для поиска меьшего значения сумм строк
    int rowArray = 1;       // для записи строки с меньшей суммой
    for (int i = 1; i < arrSum.Length; i++)
    {
        if (temp > arrSum[i])
        {
            temp = arrSum[i];
            rowArray = i + 1;
        }
    }
    System.Console.WriteLine($"\n Наименьшая сумма переменных строки массива в строке № {rowArray}");
}

int m = 5; // количетсво строк в массиве
int n = 5;  // количество столбцов в массиве
int leftRange = 0;  // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);
PrintTwoDimArray(array);
RowSmallerSum(array);
