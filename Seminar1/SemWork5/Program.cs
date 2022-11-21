//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	//456 -> 6
	//782 -> 2
	//918 -> 8

Console.Clear();
Console.Write("введите число N - ");
int numberA = int.Parse(Console.ReadLine());
int count = numberA%10;
Console.WriteLine($"endnumber {count}");