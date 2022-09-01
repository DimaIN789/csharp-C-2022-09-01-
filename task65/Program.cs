// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите M ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N ");
int numberN = Convert.ToInt32(Console.ReadLine());


if (numberM < numberN)
{
    PrintNumbersToMN(numberM, numberN);
}
else
{
    Console.Write("N должно быть больше M");
}

void PrintNumbersToMN(int m, int n)
{
    if (n < m) return;
    // Console.Write(n + " ");
    PrintNumbersToMN(m, n - 1);
    Console.Write(n + " ");
}