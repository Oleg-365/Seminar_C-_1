/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Main();

void Main()
{
    Console.Clear();
    //Данные первого двумерного массива.
    Console.WriteLine("Ввод данных для первого массива.");
    int rows1 = Prompt("Введите количество строк массива: ");                    //Ввод строк
    int columns1 = Prompt("Введите количество столбцов массива: ");              //Ввод столбцов
    int start1 = Prompt("Введите начало массива: ");                             //Ввод начала длинны массива
    int end1 = Prompt("Введите конец массива: ");                                //Ввод конца длинны массива
    Console.WriteLine();

    //Данные второго двумерного массива.
    Console.WriteLine("Ввод данных для второго массива.");
    int rows2 = Prompt("Введите количество строк массива: ");                    //Ввод строк
    int columns2 = Prompt("Введите количество столбцов массива: ");              //Ввод столбцов
    int start2 = Prompt("Введите начало массива: ");                             //Ввод начала длинны массива
    int end2 = Prompt("Введите конец массива: ");                                //Ввод конца длинны массива
    Console.WriteLine();

    //Вывод первого массива
    int[,] arrayFirst = GetFirstArray(rows1, columns1, start1, end1);                         //Вызов метода заполнение двумерного массива
    Console.WriteLine("Наш массив №1: ");
    PrintFirstArray(arrayFirst);                                                          //Вызов метода печати массива
    Console.WriteLine();
    //Вывод второго массива
    int[,] arraySecond = GetSecondArray(rows2, columns2, start2, end2);                         //Вызов метода заполнение двумерного массива
    Console.WriteLine("Наш массив №2: ");
    PrintSecondArray(arraySecond);                                                          //Вызов метода печати массива
    Console.WriteLine();
    //Перемножение массивов и вывод нового массива
    Comparison(arrayFirst, arraySecond);
    int[,] arrayThird = DivArray(arrayFirst, arraySecond);
    Console.WriteLine("Наш новый перемноженный массив №3: ");
    PrintThirddArray(arrayThird); 
}

int Prompt(string message)                                                      //Метод ввода данных
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetFirstArray(int m, int n, int minValue, int maxValue)                       //Метод заполнения двумерного массива
{
    int[,] resultOne = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultOne[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resultOne;
}

void PrintFirstArray(int[,] firstArray)                                              //Метод печати двумерного массива
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            Console.Write($"{firstArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int[,] GetSecondArray(int m, int n, int minValue, int maxValue)                       //Метод заполнения двумерного массива
{
    int[,] resultTwo = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultTwo[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resultTwo;
}

void PrintSecondArray(int[,] secondArray)                                              //Метод печати двумерного массива
{
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            Console.Write($"{secondArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}
void Comparison(int[,] firstArray, int[,] secondArray)
{
    if (firstArray.GetLength(0) != secondArray.GetLength(1))
    {
        Console.Write("Такие массивы перемножить нельзя!");
    }
}
int[,] DivArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int [firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i,j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray;
}

   void PrintThirddArray(int[,] arrayThird)                                              //Метод печати двумерного массива
{
    for (int i = 0; i < arrayThird.GetLength(0); i++)
    {
        for (int j = 0; j < arrayThird.GetLength(1); j++)
        {
            Console.Write($"{arrayThird[i, j]}   ");
        }
        Console.WriteLine();
    }
}

