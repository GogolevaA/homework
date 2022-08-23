Console.Write("Введите трехзначное число а:");
int a = Convert.ToInt32(Console.ReadLine());
if (a<100)
{
    Console.WriteLine("Третьей цыфры нет");
}
else 
{
    Console.WriteLine(a%10);
}
