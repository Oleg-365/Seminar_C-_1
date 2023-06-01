/*
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
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

int[] GetOneArray(int[,] twoArray)
{
    int[] array = new int[twoArray.Length];
    int index = 0;
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            array[index] = twoArray[i, j];
            index++;
        }
    }
    return array;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void CountElements(int[] array)
{
    int count = 1;
    int temp = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (temp != array[i])
        {
            Console.WriteLine($"{temp} встречается {count} раз");
            count = 1;
            temp = array[i];
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{temp} встречается {count} раз");

}


Console.Clear();
int[,] myArray = GetArray(3, 3, 0, 10);
PrintArray(myArray);
int[] sortArray = GetOneArray(myArray);
Console.WriteLine(string.Join(",", sortArray));
SortArray(sortArray);
Console.WriteLine(string.Join(",", sortArray));
CountElements(sortArray);


