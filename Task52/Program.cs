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
    int[] sortArray = GetOneArray(array);
    Console.WriteLine();
    Console.WriteLine(string.Join(",", sortArray));
    //MinSumRow(array);                                                          //Вызов метода подсчета ср. ариф. суммы в столбцах
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


/*void MinSumRow(int[,] array, int index)
{
    int[] res = new int[array.GetLength(0)];
    int sum = 0;
    Console.Write($"Сумма элементов каждой строки: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, 0];
    }
    Console.Write($"{sum}; ");

    int index = 0;
    int minSum = 1;
    if (minSum[index] < sum)
    {
        minSum = sum;
    }
    Console.Write($"Строка с наименьшей суммой = {minSum}.");
}*/

