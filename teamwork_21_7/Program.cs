// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3}\t");
//         Console.WriteLine();

//     }
// }

//     void FillArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             for (int j = 0; j < array.GetLength(1); j++)
//                 array[i, j] = i+j;
//     }

//   Console.WriteLine("Ведите количество строк двумерного массива");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Ведите количество столбцов двумерного массива");
//     int cols = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, cols];
//     FillArray(array);
//     PrintArray(array);


// Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

void PrintArray(int[,] array)
{   Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();

    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(0); k++)
                for (int z = 0; z < array.GetLength(1); z++)
                    if (array[k, z] > array[i, j])
                        (array[k, z], array[i, j]) = (array[i, j], array[k, z]);
}

    Console.WriteLine("Ведите количество строк двумерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ведите количество столбцов двумерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    SortArray(array);
    PrintArray(array);



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
