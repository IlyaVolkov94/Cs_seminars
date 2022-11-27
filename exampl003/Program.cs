// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Четверть №1");
    else if (x > 0 && y < 0) Console.WriteLine("Четверть №4");
    else if (x < 0 && y > 0) Console.WriteLine("Четверть №2");
    else if (x < 0 && y < 0) Console.WriteLine("Четверть №3");
    else Console.WriteLine("Точка находится на координатной оси");
}

string CheckKoord2(int x, int y)
{
    string res;
    if (x > 0 && y > 0) res = "Четверть №1";
    else if (x > 0 && y < 0) res = "Четверть №4";
    else if (x < 0 && y > 0) res = "Четверть №2";
    else if (x < 0 && y < 0) res = "Четверть №3";
    else res = "Точка находится на координатной оси";
    return res;
}


try     //Если трай не выполняется, программа переключается на catch
{
    Console.WriteLine("Введите координату X");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y");
    int y = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x, y);
    Console.WriteLine(CheckKoord2(x, y));
}

catch
{
    Console.WriteLine("Надо вводить целые числа");
}