//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Примеры
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Можно было конечно решить в лоб сравнением переменных через if, но пусть будет так)))) 

Console.Clear();
Console.WriteLine("Введите три числа через запятую");
//Полученные числа загоняем в массив и преобразуем string в int
int[] numbers = Array.ConvertAll<string,int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32 (elem);});

Console.WriteLine($"max number {numbers.Max()} ");