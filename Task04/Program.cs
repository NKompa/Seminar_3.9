// Программа принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии: A = 3; B = 5 -> 243 (3⁵).

int PowerNumber (int a, int b)
{
    if (b==0) return 1;
    return a * PowerNumber (a,b-1);
}
Console.WriteLine(PowerNumber(2,3));
