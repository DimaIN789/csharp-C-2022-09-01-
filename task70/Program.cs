// 


int n = 5;
int res = SumCount(n);
Console.WriteLine(res);

int SumCount(int number)
{
    if (number < 1) return 0;
    return 1 + SumCount(number - 1);
}
