//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Main();

void Main()
{
    Console.Clear();
    int rows = Prompt("Введите количество строк массива: ");                    //Ввод строк
    int columns = Prompt("Введите количество столбцов массива: ");              //Ввод столбцов
    int start = Prompt("Введите начало массива: ");                             //Ввод начала длинны массива
    int end = Prompt("Введите конец массива: ");                                //Ввод конца длинны массива
    

    double[,] array = GetArray(rows, columns, start, end);                          //Вызов метода заполнение двумерного массива
    PrintArray(array);
}

int Prompt(string message)                                                      //Метод ввода данных
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] GetArray(double m, double n, double minValue, double maxValue)        //Метода заполнение двумерного массива
{
    double[,] result = new double[(int)m, (int)n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)                                              //Метод печати двумерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}