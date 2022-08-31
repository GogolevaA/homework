string function()
{
    Console.WriteLine("введите 5 значное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 10000 & number < 100000)
    {
        int digit1 = number/10000;
        int digit5 = number%10;
        int digit2 = number%10000/1000;
        int digit4 = number%100/10;
        if (digit1==digit5 & digit2==digit4) return "полинтропно";
        else return "не полинтропно";
    }
    else return "5 значное введите";
}
try
{
    Console.WriteLine(function());

}
catch
{
    Console.WriteLine("not number");  
}