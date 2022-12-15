// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.




void PrintTwoDimArray(int[,] array)  // метод вывода двумерного массива в терминал
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

void ReverseArrayRorws(int[,] array)
{
   int indexEndRows = array.GetLength(0) -1;

      for (int j = 0; j < array.GetLength(1); j++)
      {
        int temp = array[0,j];
        array[0,j] = array[indexEndRows,j];
        array[indexEndRows,j] = temp;
      }
}
int m = 3; // количетсво строк в массиве
int n = 4;  // количество столбцов в массиве
int leftRange = 0;  // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

int[,] array = TwoDimArray(m,n,leftRange,rigthRange);
PrintTwoDimArray(array);
ReverseArrayRorws(array);
System.Console.WriteLine();
PrintTwoDimArray(array);