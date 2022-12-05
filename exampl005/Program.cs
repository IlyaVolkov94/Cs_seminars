﻿// Надайте массив из И элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int Size)
{
    int[] Array = new int[Size];
    for (int i = 0; i < Size; i++)
        Array[i] = new Random().Next(-9, 10);
        return Array;
}

void FindSums(int[] Array)
{
    int SumP = 0;
    int SumN = 0;
    //Цикл проходящий по всем значениям Array, то есть el принимает по очереди все значения массива (Цикл чтения (индекст им не словить, только содержимое))
    foreach (int el in Array)
    {
        Console.Write($"{el} ");
        if (el > 0) SumP += el;
        else SumN += el;
    }
    Console.WriteLine("");
    Console.WriteLine($"Cумма положительных чисел: {SumP}");
    Console.WriteLine($"Cумма отрицательных чисел: {SumN}");
}

int[] FindSums2(int[] Array)
{
    int[] Result = new int[2];
    foreach (int el in Array)
    {
        if (el > 0) Result[0] += el;
        else Result[1] += el;
    }
    return Result;
}

/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
