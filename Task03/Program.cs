// Программа принимает на вход число и возвращать сумму его цифр. 453 -> 12.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int n)
{
    if(n == 0) return 0;
    return (n % 10 + SumNumber(n/10));
}
Console.WriteLine(SumNumber(number));