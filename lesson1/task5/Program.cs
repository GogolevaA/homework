Console.WriteLine("Введите целое число:");
int a; //init
a = Convert.ToInt32(Console.ReadLine()); //присвоить
while (a != 0)
{
    Console.Write(a%10+ ",\n");
    a = a/10;
}
