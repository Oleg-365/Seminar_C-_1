//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Main();

void Main()
{
    int Size = PromptA();                               //Вызов метода ввода размера массива
    int start = PromptB();                              //Вызов метода ввода начала массива                         
    int end = PromptC();                                //Вызов метода ввода конца массива
    int[] array = GetArray(Size, start, end);
    //int[] array = GetArray(6, 1, 5);
    Console.Write($"Наш массив: ");
    PrintArray(array);                                  //Вывод массива на экран
    SumOfOddElements(array);                            // Метод вычисления суммы по нечетным позициям(индексам)
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


void SumOfOddElements(int[] array)                        // Метод вычисления суммы по нечетным позициям(индексам)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        Sum = Sum + array[i];
    }
    Console.Write($"Сумма нечетных элементов составляет: {Sum}.");
    Console.WriteLine();
}

int[] GetArray(int size, int numA, int numB)                    // Метод заполнение массива рандомными числами
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(numA, numB + 1);
    }
    return res;
}

void PrintArray(int[] array)                                     //Вывод массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($" {array[i]} ");

    }
    Console.Write("]");
    Console.WriteLine();
}





