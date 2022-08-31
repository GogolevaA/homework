// string cub3();
// {
    Console.WriteLine("Введите положительное число");
    int N = Convert.ToInt32(Console.ReadLine());
    string res = "";
    for ( int i = 1; i <= N; i++)
    {
      res = res + i*i*i+",";
    }
// return res;
// Console.WriteLine(cub3());
Console.WriteLine(res);