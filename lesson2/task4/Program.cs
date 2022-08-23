Console.Write("Введите введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
if(a%10==1)
{
    Console.WriteLine(a + "  програмист");
}
else if (a%10==2 || a%10==3 || a%10==4 )
{
     Console.WriteLine(a + "  програмиста");
}
else 
{
     Console.WriteLine(a + "  програмистов");
}