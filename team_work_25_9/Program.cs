// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumNumber(int number)
{
    int sum = 0;
    while (true)
    {
        sum += number % 10; // sum = sum + number%10;
        number /= 10; // number = number/10;
        if (number == 0)
            break;
    }
    return sum;
}

int SumNumberRec(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumNumberRec(number / 10);
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumberRec(number);
Console.WriteLine($"Сумма цифр числа равна: {result}");