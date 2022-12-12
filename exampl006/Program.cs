// Поменять элементы массива местами зеркально

int[] CreateArray(int Size)
{
    int[] Array = new int[Size];
    for (int i = 0; i < Size; i++)
        Array[i] = new Random().Next(-9, 10);
    return Array;
}

void PrintArray(int[] Array)
{
    foreach(int Print in Array)
        Console.Write(Print + " ");
    Console.WriteLine("");
}

void Reverse(int[] Array)
{
    int Temp = 0;
    for (int i = 0; i < Array.Length / 2; i++)
    {
        Temp = Array[i];
        Array[i] = Array[Array.Length - 1 - i];
        Array[Array.Length - 1 - i] = Temp;
    }
}

Console.WriteLine("Введите ");
int x = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateArray(x);
PrintArray(Array);
Reverse(Array);
PrintArray(Array);