// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.WriteLine(array[i]);
//     }
//     return array;
// }


// int GetMaxValue(int[] array)
// {
//    int max = array[0];
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > max) max = array[i];
//    }
//    return max;
// }


// int GetMinValue(int[] array)
// {
//    int min = array[0];
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] < min) min = array[i];
//    }
//    return min;
// }

// int result(int max, int min)
// {
//    int result = max - min;
//    return max - min;
// }


// try
// {

//   Console.Write("Введите длину массива: \t");
//     int number = Convert.ToInt32(Console.ReadLine());
//    result(GetMaxValue(GetMinValue(FillArray(number))));
// }
// catch
// {
//    Console.WriteLine("Ошибка. Введите число!!");
// }


int[] FillArray(int size)

{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,10);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine(array[i]);
    }
    return array;
}
int razniza(int[] array)
{

   int max = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > max) max = array[i];
   }
    int min = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] < min) min = array[i];
   }
   int result=0;
   result=max-min;
   Console.WriteLine(result);
   return result;
 }
 Console.Write("Введите длину массива: \t");
int size = Convert.ToInt32(Console.ReadLine());
razniza(FillArray(size));