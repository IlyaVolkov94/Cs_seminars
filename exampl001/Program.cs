Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int square = num*num;
//Console.WriteLine("Квадрат введенного числа равен"+square);
Console.WriteLine($"Квадрат введенного числа равен {square}");

if (num>9)
{
    Console.WriteLine("Вы ввели двухзначное число");
}