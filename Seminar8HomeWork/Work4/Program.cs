// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] NotRepeatingRandom(int length, int heigth, int weigth, int leftRange, int rigthRange)  // создать массив наполненный не повторяющимися рандомными значениями
{

    int[] arrRandom = new int[length * heigth * weigth];
    int temp = 0;
    if (length * heigth * weigth > rigthRange - leftRange)      // проверка на т очто хватит чисел для полного заполнения массива
    {
        System.Console.WriteLine("    ERROR \n rigthRange - leftRange >= length * heigth * weigth ");
        return arrRandom;               // не нашел команды для прекрашения выполнения метода без вывода
    }

    for (int i = 0; i < arrRandom.Length; i++)
    {
        arrRandom[i] = new Random().Next(leftRange, rigthRange + 1);
        temp = arrRandom[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arrRandom[i] == arrRandom[j])
                {
                    arrRandom[i] = new Random().Next(leftRange, rigthRange + 1);
                    j = 0;
                    temp = arrRandom[i];
                }

                temp = arrRandom[i];
            }

        }
    }
    return arrRandom;
}

int[,,] ThreeDimArray(int length, int heigth, int weigth, int leftRange, int rigthRange)  // cоздать  трехмерный массив наполненный рандомом
{
    int[,,] array = new int[length, heigth, weigth];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(leftRange, rigthRange + 1);

            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 1; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == array[i, j, k - 1])

                    array[i, j, k] = new Random().Next(leftRange, rigthRange + 1);

            }
        }
    }
    return array;
}

void PrintThreeDimArray(int[,,] array)  // метод вывода трехмерного массива в терминал
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k})");
                if (k < array.GetLength(2)) System.Console.Write(" ; ");
            }

        }
        System.Console.Write("]");
        System.Console.WriteLine();
    }
}

void PasteInArray(int[,,] arrayCube, int[] array)
{
    if (arrayCube.Length != array.Length)
    {
        System.Console.WriteLine("ERROR \n arrayCube.Length != array.Length");
        return;
    }

    int m = 0;     // счетчик 

    while (m < array.Length)
    {
        for (int i = 0; i < arrayCube.GetLength(0); i++)
        {
            for (int j = 0; j < arrayCube.GetLength(1); j++)
            {
                for (int k = 0; k < arrayCube.GetLength(2); k++)
                {
                    arrayCube[i, j, k] = array[m];
                    m++;
                }
            }
        }
    }
}


int row = 2; // длина массива
int column = 2;  // ширина массива
int weigth = 2;  // высота массива
int leftRange = 0; // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

int[,,] cubeArray = new int[row, column, weigth];
PrintThreeDimArray(cubeArray);
int[] arrayNoRepeat = NotRepeatingRandom(row, column, weigth, leftRange, rigthRange);
PasteInArray(cubeArray,arrayNoRepeat);
PrintThreeDimArray(cubeArray);