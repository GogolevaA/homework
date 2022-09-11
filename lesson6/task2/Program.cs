// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


    Console.WriteLine("Введите первое значение b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе значение b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе значение K1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе значение K2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    PrintArray(b1, b2, k1, k2);

    void PrintArray(int b1, int b2, int k1, int k2)
    {

    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
   } 

