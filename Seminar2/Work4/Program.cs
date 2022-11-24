//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.

//14 -> нет 
//46 -> нет 
//161 -> да

Console.Clear();
Console.WriteLine("Enter numberA");
int numberA = int.Parse(Console.ReadLine());

if ((numberA % 23 == 0) && (numberA % 7 == 0))

{
    Console.WriteLine("кратно");
}

else
{
    Console.WriteLine("не кратно");
}
