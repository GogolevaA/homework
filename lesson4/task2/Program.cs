// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Factorial(int N);
{
    int sum =0;
        for ( int i = 0; i <= N; i++)
        {
            i=N%10;
            N=N/10;
            sum +=i;
        }
    return sum;
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(N));
