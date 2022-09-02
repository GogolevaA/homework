// See https://aka.ms/new-console-template for more information
//ссумма элеентов на нечетных позициях
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
    
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}
try
{
    // Console.Write("Введите длину массива: \t");
    int number = 8;
    PrintArray((FillArray(number)));
}
catch 
{
    Console.WriteLine("Fatal Error!!");
}