// Задача 69: Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B ");
int numberB = Convert.ToInt32(Console.ReadLine());
int res = DegreeAtoB(numberA, numberB);
Console.WriteLine(res);

int DegreeAtoB(int a, int b)
{
    if (b < 1) return 0;
    return a * DegreeAtoB(a, b - 1);
}

