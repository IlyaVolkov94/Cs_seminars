// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string res = "";

// while (num>0)
// {
//     res = Convert.ToString(num%2) + res;
//     num = num / 2;
// }
// Console.WriteLine(res);

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int Bin = 6;
while(Num>0)
{
    Bin= Bin+Num%2;
    Bin*=10;
    Num/=2;
}

//Последний разряд удаляешь, первый разряд преобразуешь if(первый разряд ==6) первый разряд = 0; else первый разряд =1)
Console.WriteLine(Bin);