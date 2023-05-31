/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

[1,7] -> такого числа в массиве нет*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);              //Ввод строк

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);           //Ввод столбцов

Console.Write("Введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);            //Ввод начала длинны массива

Console.Write("Введите конец массива: ");               //Ввод конца длинны массива
int end = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, start, end);  //Вызов метода заполнение двумерного массива

Console.WriteLine("Исходный массив: ");
PrintArray(array);

ComparingNumbers(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)                         //печать двумерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ComparingNumbers(int[,] userArray)
{
    Console.Write("Введите число для нахождения в массиве: ");               //Ввод доп. числа для нахождения его в массиве
    int number = int.Parse(Console.ReadLine()!);

    foreach (int el in userArray)
    {
        if (el < 0 | el > userArray.GetLength(0) - 1 | el > userArray.GetLength(1) - 1)
        {
            Console.WriteLine($"Введенное число {number} отсутствует в данном массиве.");
        }
        else
        {
            Console.WriteLine($"Введенное число {number} есть в данном массиве.");
            
        }
    }
    Console.WriteLine();
}


