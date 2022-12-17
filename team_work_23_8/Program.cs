﻿// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();

    }
}

void ChangeRows(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        (array[0,j], array[array.GetLength(0) - 1, j]) = (array[array.GetLength(0) - 1,j], array[0,j]);
    }
}

    Console.WriteLine("ВВедите количество строк двумерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ВВедите количество столбцов двумерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[rows, cols];
        FillArray(array);
        PrintArray(array);
        ChangeRows(array);
        Console.WriteLine();
        PrintArray(array);