/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

[1,7] -> такого числа в массиве нет*/

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

    SearchByCoordinates(array);
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
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void SearchByCoordinates(int[,] userArray)                                  //Метод поиска числа в массиве по координатам
{
    Console.WriteLine("Введите координаты");
    int position1 = Convert.ToInt32(Console.ReadLine());
    int position2 = Convert.ToInt32(Console.ReadLine());
    
    if (position1 < 0 | position1 > userArray.GetLength(0) - 1 | position2 < 0 | position2 > userArray.GetLength(1) - 1)
        Console.WriteLine("Такого числа нет!");
    else
    {
        object element = userArray.GetValue(position1, position2)!;
        Console.Write($"Значение элемента массива = [{element}].");
    }
}