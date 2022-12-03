// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе: {countNumber(num)}");

int countNumber(int arg)
{
    int count = 0;
    while (arg >= 1)
    {
        arg = arg / 10;
        count++;
    }
    return count;
}