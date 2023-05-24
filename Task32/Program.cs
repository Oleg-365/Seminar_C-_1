//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Main();
void Main()
{
    int[] array = GetArray(5, 1, 10);
    Console.Write($"Наш массив: ");
    PrintArray(array);
}


for (int i = 0; i < array.Length; i++)
{
    arr[i] = minEl
}

//int Sum =0;
//for (int i = 0; i < array.Length; i++)
////{
 //   Sum = minElement +
//}


    int[] GetArray(int size, int numA, int numB)
    {
        int[] res = new int[size];
        for (int i = 0; i < size; i++)
        {
            res[i] = new Random().Next(numA, numB + 1);
        }
        return res;
    }

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}




