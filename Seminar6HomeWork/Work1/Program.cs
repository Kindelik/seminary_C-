// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4




Console.Clear();
Console.WriteLine("Введите числа через запятую");
//Полученные числа загоняем в массив и преобразуем string в int
int[] numbers =  Console.ReadLine().Split(',').Select(int.Parse).ToArray();

int quantity =0;  // счетчик положительных чисел

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]>0)
    {
        quantity++;
    }
}
System.Console.WriteLine($"Количетсво положительных чисел = {quantity}");