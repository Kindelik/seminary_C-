//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	//456 -> 6
	//782 -> 2
	//918 -> 8

Console.Clear();
Console.Write("введите трехзначное число N - ");
int numberA = int.Parse(Console.ReadLine());
if((numberA > 99)&&(numberA<1000))   //&& это "и" || это или не исключающее
{
   int count = numberA%10;
   Console.WriteLine($"endnumber {count}");
}
else
{
    Console.WriteLine("number incorrect");
}



//int GetDigitCount(string s)
//{
//   if (string.IsNullOrEmpty(s)) throw ...
//   if (!s.All(char.IsDigit)) throw ...
// 
//   return s.Length;
//}