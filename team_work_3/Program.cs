Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int negNum=-1*num;
while (negNum<=num)
{
    Console.Write($"{negNum} ");
    negNum++;
}
Console.WriteLine();