//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Main();
void Main()
{
    int Size = PromptA();
    int start = PromptB();
    int end = PromptC();
    int[] array = GetArray(Size, start, end);           // Вызов метода заполнения массива случ-ми числами
  //int[] array = GetArray(4, 100, 1000);
    Console.Write($"Наш массив: ");
    PrintArray(array);                                  //Вывод массива на экран
    CountEvenNumbers(array);                            //Метод нахождения четных чисел в массиве
}
int PromptA()                                           //Вызов метода ввода размера массива
{
    Console.Write("Введите размер массива: "); 
    int size = Convert.ToInt32(Console.ReadLine()); 
    return size;
}
int PromptB()                                            //Вызов метода ввода начала массива
{
    Console.Write("Введите начало массива: ");
    int namberA = Convert.ToInt32(Console.ReadLine());
    return namberA;
}
int PromptC()                                            //Вызов метода ввода конца массива
{
    Console.Write("Введите конец массива: ");
    int namberB = Convert.ToInt32(Console.ReadLine());
    return namberB;
}

void CountEvenNumbers(int[] array)                       //Метод нахождения четных чисел в массиве
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"Всего в массиве {array.Length} чисел(числа), {count} из них чётные.");
}

int[] GetArray(int size, int numA, int numB)             // Метод заполнение массива рандомными числами
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(numA, numB + 1);
    }
    return res;
}

void PrintArray(int[] array)                            //Вывод массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($" {array[i]} ");

    }
    Console.Write("]");
    Console.WriteLine();
}






