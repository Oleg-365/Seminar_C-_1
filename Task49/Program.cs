/*
Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
*/



int[,] GetArray(int row, int col, int valueMin, int valueMax)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(valueMin, valueMax);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool isSquareArray(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}

void ChengeColRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp = array[i, j + 1];
            array[i, j + 1] = array[i + 1, j];
            array[i + 1, j] = temp;
        }
    }
}

Console.Clear();
int[,] myArray = GetArray(3, 3, 0, 10);
PrintArray(myArray);

if (!isSquareArray(myArray))
{
    Console.WriteLine("Не квадрат!");
}
else
{
    Console.WriteLine();
    ChengeColRow(myArray);
    PrintArray(myArray);
}