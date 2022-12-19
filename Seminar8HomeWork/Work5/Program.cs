// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Я в курсе что не стоит столько коментариев оставлять, но потом я хочу сделать на основе этой задачи метод, для матрицы любого размера

int row = 4; // количетсво строк в массиве 
int column = 4;  // количество столбцов в массиве 

int[,] twoArray = new int[row, column];
int meaning = 0;  // значение которое будем вставлять в массив
bool rigthLeft = true;
bool upDown = true;
int count = 0;
int countRow = 0; //счетчик проходов и чего то еще
int countColumn = 0; //счетчик проходов и чего то еще


while (count < 3)
{
    if ((rigthLeft == true) & (upDown == true))     // двигаемся вправо
    {
        for (int i = 0 + count; i < 4 - count; i++)
        {
            meaning++;
            twoArray[countRow, i] = meaning;
            countColumn = i;
            //System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}"); // проверочный
        }
        upDown = false;
    }
    if ((rigthLeft == true) & (upDown == false))     // двигаемся вниз
    {
        for (int i = 1 + count; i < 4 - count; i++)
        {
            meaning++;
            twoArray[i, countColumn] = meaning;
            countRow = i;
            //System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");
        }
        rigthLeft = false;
    }
    if ((rigthLeft == false) & (upDown == false))     // двигаемся влево
    {
        for (int i = 2 - count; i >= 0 + count; i--)
        {
            meaning++;
            twoArray[countRow, i] = meaning;
            countColumn = i;
            //System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}");    // проверочный
        }
        upDown = true;
    }
    if ((rigthLeft == false) & (upDown == true))     // двигаемся вверх
    {
        for (int i = 2 - count; i > 0 + count; i--)
        {
            meaning++;
            twoArray[i, countColumn] = meaning;
            countRow = i;
            // System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");    // проверочный
        }
        rigthLeft = true;
        count++;
    }
}




// Пытался сделать решение более гибким. Потерпел неудачу
// Можете подсказать где я ошибся?

/*
while (meaning < row * column + 1)
{
    if ((rigthLeft == true) & (upDown == true))     // двигаемся вправо
    {
        for (int i = 0 + count; i < twoArray.GetLength(0) - count; i++)
        {
            meaning++;
            twoArray[countRow, i] = meaning;
            countColumn = i;
            System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}"); // проверочный

        }
        upDown = false;

    }
    if ((rigthLeft == true) & (upDown == false))     // двигаемся вниз
    {
        for (int i = 1 + count; i < twoArray.GetLength(1) - count; i++)
        {
            meaning++;
            twoArray[i, countColumn] = meaning;
            countRow = i;
            System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");
        }
        rigthLeft = false;
    }
    if ((rigthLeft == false) & (upDown == false))     // двигаемся влево
    {
        for (int i = twoArray.GetLength(0) - 1 - count; i > 0 + count; i--)
        {
            meaning++;
            twoArray[countRow, i] = meaning;
            countColumn = i;
            System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}");    // проверочный
        }

        upDown = true;
         count++;
    }
    if ((rigthLeft == false) & (upDown == true))     // двигаемся вверх
    {
        for (int i = twoArray.GetLength(1) - 1 - count; i > 0 + count; i--) 
        {
            meaning++;
            twoArray[i, countColumn] = meaning;
            countRow = i;
            System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");
        }
        rigthLeft = true;
       
    }
}
*/