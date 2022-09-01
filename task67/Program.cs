// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
int res = SumCount(n);
Console.WriteLine(res);

int SumCount(int number)
{
    if (number <= 0) return 0;
    return number % 10 + SumCount(number / 10);
}

