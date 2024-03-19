// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

System.Console.Clear();

System.Console.WriteLine("Введите натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Введено ненатуральное число");
    return;
}

void NaturalNumbers(int M, int N)
{
    if (M == N)
    {
        if (N >= 0) Console.Write($"{N}");
    }
    else
    {
        if (M < N)
        {
            NaturalNumbers(M, N - 1);
            if (N >= 0) Console.Write($", {N}");
        }
        else if (M > N)
        {
            if (N >= 0) Console.Write($"{M}, ");
            NaturalNumbers(M - 1, N);
        }
    }

}
NaturalNumbers(m,n);