// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    Coordprint(num);
    Console.WriteLine(CoordCheck(num));
}
catch
{
    Console.WriteLine("Ошибка выполнения");
}

void Coordprint(int arg)
{
    if (arg == 1) Console.WriteLine("x>0, y>0");
    else if (arg == 2) Console.WriteLine("x<0, y>0");
    else if (arg == 3) Console.WriteLine("x<0, y<0");
    else if (arg == 4) Console.WriteLine("x>0, y<0");
    else Console.WriteLine("Какого четверти не существует");
}

string CoordCheck(int arg)
{
    string str;
    if (arg == 1) str = "x>0, y>0";
    else if (arg == 2) str = "x<0, y>0";
    else if (arg == 3) str = "x<0, y<0";
    else if (arg == 4) str = "x>0, y<0";
    else str = "Какого четверти не существует";
    return str;
}