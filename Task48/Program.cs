/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] GetArray(int row, int col, int valueMin, int valueMax)
        {
            int [,] array = new int[row, col];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(valueMin, valueMax);
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
                    Console.Write($" {array[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        void ChengeArray(int[,] array, int index1, int index2)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[index1, j];
                array[index1, j] = array[index2, j];
                array[index2, j] = temp;
            }
        }


        int[,] myArray = GetArray(5, 5, 0, 10);
        PrintArray(myArray);
        Console.WriteLine();
        ChengeArray(myArray, 0, myArray.GetLength(0) - 1);
        PrintArray(myArray);
    }
}