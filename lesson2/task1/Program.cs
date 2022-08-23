// a = int(input('Enter 1st number: '))
// a = a//10
// a = a % 10


// print({a})

Console.Write("Введите трехзначное число а:");
int a = Convert.ToInt32(Console.ReadLine());
int  x = a / 10;
int  b = x % 10;
Console.WriteLine("второе число-" + b);

// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[2]);