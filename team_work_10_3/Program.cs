// Напишите программу, которая принимает на вход координаты двух точек и выводит расстояние между ними в 2D пространстве

double input(string x, string y)
{
    Console.WriteLine($"Введите {x} координату точки {y}");
    return Convert.ToDouble(Console.ReadLine());
}

try
{
    double xA = input("x", "A");
    double yA = input("y", "A");
    double xB = input("x", "B");
    double yB = input("y", "B");
    double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
    Console.WriteLine("Расстояние меджу точками: " + Math.Round(result,2));
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}