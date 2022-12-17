// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void ChangeRowsToCols(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i; j < array.GetLength(1); j++)
        {
            (array[i, j],array[j, i])=(array[j, i],array[i, j]);
        }
}


Console.WriteLine("Ведите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows == cols)
{
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    ChangeRowsToCols(array);
    PrintArray(array);
}
else Console.WriteLine("Невозможно преобразовать");
