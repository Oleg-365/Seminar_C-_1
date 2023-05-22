//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
//6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

Main();

void Main()

{
    int[] Arr = { 1, 1, 1, 1, 1, 1, 1, 1 };
    RandArray(Arr);
    PrintArr(Arr);
}

void RandArray(int[] num)
{

    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(0, 100);
    }
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" [{array[i]}] ");
    }
    Console.WriteLine();
}
//************************************************

// Эталлонное решение задачи
//int Prompt (string message)
//{
//    System.Console.Write (message); //выводим приглашение ко вводу
//    string readInput = System.Console.ReadLine(); //Вводим значение
//    int result = int.Parse (readInput); //приводим к числу
//    return result; // Возвращаем результат
//}
// метод для получения случайных значений массива
//int[] GenerateArray(int Length, int minValue, int maxValue)
//{
//    int[] array = new int[Length]; //объявляем массив
//    Random random = new Random();
//    for (int i = 0; i < Length; i++)
//    {
//        array[i] = random.Next(minValue, maxValue + 1); //заполняем случайными цифрами из диапазона SatrArr до EndArr
//    }
//  return array;
//}
//void PrintArray(int[] array)
//{
//    System.Console.Write("[");
//    for (int i = 0; i < array.Length - 1; i++)
//    {
//        System.Console.Write($"{array[i]}, "); // вывод значения массива
//    }
//    System.Console.Write($"{array[array.Length - 1]}"); // вывод значения массива
//    System.Console.Write("]");
//}
//int length = Prompt ("Длина массива: ");
//int min = Prompt ("Начальное значение, для диапазона случайного числа: ");
//int max = Prompt ("Конечное значение, для диапазона случайного числа: ");
//int[] array = GenerateArray(length, min, max);
//PrintArray (array);
