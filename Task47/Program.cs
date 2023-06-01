/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
    SumMeanByColumns(array);                                                    //Вызов метода подсчета ср. ариф. суммы в столбцах
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

void SumMeanByColumns(int[,] userArray)                                        //Метода подсчета ср. ариф. суммы в столбцах
{
    Console.Write($"Среднее арифметическое элементов каждого столбца: ");
    
    for (int j = 0; j < userArray.GetLength(1); j++)
    {
        double sum = 0;
        double sumArithmeticMean = 0;
        
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            sum += userArray[i, j];
            sumArithmeticMean = Math.Round((sum / userArray.GetLength(0)),2);
        }
        Console.Write($"{sumArithmeticMean}; ");
    }
}

