// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.WriteLine("Введите основание");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowRec(numberA, numberB));


int Pow(int numberA, int numnerB)
{
    int result = 1;
    while (true)
    {
        result *= numberA;
        numnerB--;
        if (numnerB == 0)
            break;
    }
    return result;
}
// int result = 1;
// for (int i = 0;i<numberB;i++)
//     result= result*numberA;



int PowRec(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return numberA * PowRec(numberA, numberB - 1);
}

// numberA * (numbarA * (numberA*(1)))