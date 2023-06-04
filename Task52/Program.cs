/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
    SumOfRowElements(array);
    Console.WriteLine();
    MinSumElements(array);                                                     //Вызов метода нахождения min суммы строки


    //MinSumRow(array);                                                          
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

void SumOfRowElements(int[,] userArray)                                        //Метода подсчета суммы в строках
{
    Console.Write($"Сумма элементов каждой строки: ");
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            sum += userArray[i, j];
        }
        Console.Write($"{sum}; ");
    }
}


void MinSumElements(int[,] array)                                           //Метода подсчета мин суммы в строках
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }

        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов = {minSumRow + 1}.");
}
