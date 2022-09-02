// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine(array[i]);
    }
    return array;
}
static int CountValues(int[] array)

        {
            int count=0;
            for (int i = 0; i < array.Length; i++)
        
            if (array[i]%2==0)
            {
            count++;
            // Console.WriteLine(count);
            }
            // int count=0;
            // foreach (int item in array) if (item / 2 == 0 ) count++; item++;
            // Console.WriteLine(count);
            Console.WriteLine(count);
            return count;
        //    count++;
            // Console.WriteLine(count);
            // Console.WriteLine(count);
        }

// void PrintArray(int count)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.WriteLine($"{array[i]}]");
//     }
// }
try
{
    Console.Write("Введите длину массива: \t");
    int number = Convert.ToInt32(Console.ReadLine());
   CountValues(FillArray(number));
}
catch 
{
    Console.WriteLine("Fatal Error!!");
}