//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.Clear()
Console.WriteLine("Hello, User!");

Console.WriteLine("Введите число дня недели");
int numberA = int.Parse(Console.ReadLine());
if (numberA == 1) Console.WriteLine("Понедельник");
if (numberA == 2) Console.WriteLine("Вторник");
if (numberA == 3) Console.WriteLine("Среда");
if (numberA == 4) Console.WriteLine("Четверг");
if (numberA == 5) Console.WriteLine("Пятница");
if (numberA == 6) Console.WriteLine("Суббота");
if (numberA == 7) Console.WriteLine("Воскресенье");