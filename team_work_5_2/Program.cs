// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированное случайное число {num}");
int x1 = num%10;
num=num/100;
num=num*10;
num=num + x1;
Console.WriteLine($"Ответ {num}");

// ИЛИ
// int num = new Random().Next(100,1000);
// Console.WriteLine($"Сгенерировано случайное число {num}");
// int result = num / 100; // 3 цифра (количество сотен)
// int result1 = num % 10; // 1 цифра (количество единиц)
// Console.WriteLine($"{result}{result1}");