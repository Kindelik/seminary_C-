// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



int[] DataЕntry(string str)                                              // Метод Ввод через , и перевод в массив

{
    Console.WriteLine(str);

    int[] numbers = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32(elem); });

    return numbers;
}

Console.WriteLine("Enter coordinates separated by commas");     // Координаты вводить через ,
int[] numbersA = DataЕntry("Enter the coordinates of the point A");
int[] numbersB = DataЕntry("Enter the coordinates of the point B");

double Distance = Math.Sqrt(Math.Pow(numbersB[0] - numbersA[0], 2) + Math.Pow(numbersB[1] - numbersA[1], 2) + Math.Pow(numbersB[2] - numbersA[2], 2));

Console.WriteLine($"Distance between points = {Distance} ");
