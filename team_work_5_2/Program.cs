// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированное случайное число {num}");
int x1 = num%10;
num=num/100;
num=num*10;
num=num + x1;
Console.WriteLine($"Ответ {num}");