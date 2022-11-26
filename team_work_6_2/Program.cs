// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите число 1");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int numB = Convert.ToInt32(Console.ReadLine());
int div = numB%numA;
if(div==0) Console.WriteLine("Второе число кратно первому");
else Console.WriteLine("Второе число не кратно первому. Остаток:"+div);