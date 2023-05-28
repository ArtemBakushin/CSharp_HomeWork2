int number = ReadInt("Введите трехзначное число: ");
Console.WriteLine(NumberTwo(number));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberTwo ( int arg1)
{
    if(arg1 > 100 && arg1 < 1000 ) 
    {
    int a = arg1 / 10;
    int b = a % 10;
    int result = b;
    return result;
    }
    else
    {
       Console.WriteLine("Вы ввели не трехзначное число");
       return arg1 ;
    }
}
