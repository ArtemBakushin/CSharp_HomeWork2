Console.WriteLine("Введите число: ");


var stringNumber = Console.ReadLine();
int number;

bool isNumber = int.TryParse(stringNumber, out number);

if (isNumber && stringNumber.Length >= 3)
{
Console.WriteLine("Третья цифра числа: " + stringNumber[2]);
}
else
{
Console.WriteLine("Тут нет третьего числа");

}
