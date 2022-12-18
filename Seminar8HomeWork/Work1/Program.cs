// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

void BubbleSort(int[,] mas)   // метод сортировки строки массива
{
    int temp;                             // для 
    for (int i = 0; i < mas.GetLength(0); i++)      // для перевода строк
    {
        for (int m = 0; m < mas.GetLength(1); m++)     // для прокрутки пузырьков

        {
            for (int j = 1; j < mas.GetLength(1); j++)     // для перевода по строке
            {
                if (mas[i, j] > mas[i, j - 1])
                {
                    temp = mas[i, j];
                    mas[i, j] = mas[i, j - 1];
                    mas[i, j - 1] = temp;
                }
            }
        }
    }
}

void PrintTwoDimArray(int[,] array)  // метод вывода двумерного массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}");
            if(j < array.GetLength(1)-1) System.Console.Write(" ; ");
        }
        System.Console.Write("]");
        System.Console.WriteLine();
    }
}

int m = 5; // количетсво строк в массиве
int n = 5;  // количество столбцов в массиве
int leftRange = -100;  // значение "от" целых чисел массива
int rigthRange = 100;  // значение "до" целых чисел массива включительно

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);
System.Console.WriteLine("\n Unsorted array\n");
PrintTwoDimArray(array);
BubbleSort(array);
System.Console.WriteLine("\n Sorted array\n");
PrintTwoDimArray(array);