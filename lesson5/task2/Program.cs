// void treug()
// {
//     Console.Write("Введите  число а:");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите  число b:");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите  число с:");
//     int c = Convert.ToInt32(Console.ReadLine());
//     if (a+b>c & a+c>b & b+c>a)
//     {
//         Console.WriteLine("Треугольник существует");
//     }
//     else
//     {
//         Console.WriteLine("Увы");
//     }
// }
// treug();
// int P =a+b+c;
// int S =sqr(Math)


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

// Console.Write("Введите  число а:");
// int a = Convert.ToInt32(Console.ReadLine());
// // int massiv = Convert.ToString(a).Length;
// // int[] array = new int[a];
// int nam1=0;
// int nam2=1;
// int Reresult=0;
// Console.Write(  nam1);
// Console.Write(  nam1+nam2);
// for (int i=2; i<a; i++)
// {
//     Reresult= nam1+nam2;
//     nam1=nam2;
//     nam2=Reresult;

//     Console.Write(Reresult);
// }
// Console.WriteLine(Reresult);

// Console.Write("Введите  число а:");
// int a = Convert.ToInt32(Console.ReadLine());
// int Reresult=0;
// for (int i=0; i<=a; i++)
// while (a>=1)
// {
//     Reresult=a%2;
//     Console.WriteLine(Reresult);
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
static int CountValues(int[] array)

        {
            int sum=0;
            for (int i = 0; i < array.Length; i=i+2)
       

        
            sum=sum+array[i];

           
          
            Console.WriteLine(sum);
     
            return sum;
        
        }

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