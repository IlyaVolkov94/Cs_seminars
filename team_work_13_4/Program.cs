// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {Num} равно {MultNum(Num)}");

int MultNum(int arg)
{   
    int Mult = 1;
    for(int i=1;i<=arg;i++) Mult*=i;
    return Mult;
}