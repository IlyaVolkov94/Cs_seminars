// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int div1 = num%7;
int div2 = num%23;
if (div1==0 && div2==0) Console.WriteLine("Число кратно 7 и 23");
else Console.WriteLine("Число НЕ кратно 7 и 23");