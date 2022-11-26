// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите число 1");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int numB = Convert.ToInt32(Console.ReadLine());
int squad1 = squad (numA);
Console.WriteLine("Квадрат первого числа "+squad1);
int squad2 = squad (numB);
Console.WriteLine("Квадрат второго числа "+squad2);
if(squad1 == numB || squad2==numA)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}


int squad (int arg)
{
    return arg*arg;
}