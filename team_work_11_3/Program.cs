// Напишите программу, которая на вход принимает число N и выдает квадраты чисел от 1 до N
Console.WriteLine("Введите число");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Квадраты числе от 1 до {num}:");
    for (int i = 1; i <= num; i++)
    {
        int result = i * i;
        Console.Write($"{result} ");
    }
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}