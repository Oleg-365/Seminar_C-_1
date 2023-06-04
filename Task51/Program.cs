/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Main();

void Main()
{
    Console.Clear();
    int rows = Prompt("Введите количество строк массива: ");                    //Ввод строк
    int columns = Prompt("Введите количество столбцов массива: ");              //Ввод столбцов
    int start = Prompt("Введите начало массива: ");                             //Ввод начала длинны массива
    int end = Prompt("Введите конец массива: ");                                //Ввод конца длинны массива

    int[,] array = GetArray(rows, columns, start, end);                         //Вызов метода заполнение двумерного массива
    Console.WriteLine("Наш массив: ");
    PrintArray(array);                                                          //Вызов метода печати массива
    Console.WriteLine();
    Console.WriteLine("Наш массив упорядоченный по убыванию элементов каждой строки: ");
    SortToLower(array);                                                         //Вызов метода сортировки массива
    PrintArray(array);                                                          //Вызов метода печати массива

}

int Prompt(string message)                                                      //Метод ввода данных
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)                       //Метод заполнения двумерного массива
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

void PrintArray(int[,] inArray)                                              //Метод печати двумерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void SortToLower(int[,] inArray)                           //Метод сортировки по убыванию в строках двумерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - 1; k++)
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {
                    int temp = inArray[i, k + 1];
                    inArray[i, k + 1] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
}