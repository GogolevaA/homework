//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// возводим в степень
Console.WriteLine("Введите первое значение");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int b = Convert.ToInt32(Console.ReadLine());
int i = Convert.ToInt32(Math.Pow(a, b));
Console.WriteLine(i);