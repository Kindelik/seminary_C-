// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//            и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void SearchPosition(int position, int[,] array)  // Метод поиска числа по позиции в массиве
{
    int count = 0; // счетчик для перещелкивания позиции
    int rowsPosition = 0;  // для сохранения строки искомой позиции
    int columnsPosition = 0; // для сохранения столбца искомой позиции
    if (position <= array.Length)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (count == position - 1)
                {
                    rowsPosition = i;
                    columnsPosition = j;
                    System.Console.WriteLine($"На позиции {position} находится число {array[rowsPosition, columnsPosition]}");
                    System.Console.WriteLine($"Индекс числа {array[rowsPosition, columnsPosition]} => [{rowsPosition},{columnsPosition}]");
                    count++;
                    break;
                }
                else
                {
                    count++;
                }
            }

        }
    }
    else
    {
        System.Console.WriteLine($" Не существует введенной позиции в массиве.\n Максимальная поцизия = {array.Length}");
    }
}

int m = 5; // количетсво строк в массиве
int n = 5;  // количество столбцов в массиве
int leftRange = -10;  // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно
int position = DataЕntry("Enter the item position => ");
int[,] array = TwoDimArray(m, n, leftRange, rigthRange);   //создаем рандомный массив
SearchPosition(position, array);  //решаем задачу с помощью этого метода