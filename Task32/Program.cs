//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Main();
void Main()
{
    int Size = PromptA();                               //Вызов метода ввода размера массива
    int start = PromptB();                              //Вызов метода ввода начала массива                         
    int end = PromptC();                                //Вызов метода ввода конца массива
    double[] array = GetArray(Size, start, end);
    //int[] array = GetArray(5, 1, 10);
    Console.Write($"Наш массив: ");
    PrintArray(array);                                  //Вывод массива на экран
    MinMax(array);                                      //метод нахождения разницы между макс и миним элементами массива 
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
    int numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
}
int PromptC()                                            //Вызов метода ввода конца массива
{
    Console.Write("Введите конец массива: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    return numberB;
}


double MinMax(double[] array)                             //метод нахождения разницы между макс и миним элементами массива 
{
    double maxEl = array[0];
    double minEl = array[0];
    double Diff = 0;
    for (int i = 0; i < array.Length; i++)     
    {
        if (array[i] > maxEl)
        {
            maxEl = array[i];
        }
        if (array[i] < minEl)
        {
            minEl = array[i];
        }

    }
    Diff = Math.Round((maxEl - minEl),2);

    Console.WriteLine($"Разница между максимальным и минимальным числом = {Diff}.");
    return Diff;
}
double[] GetArray(double size, double numA, double numB)
{
    double[] res = new double [(int)size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100; //res[i] = new Random().NextDoble()*100;
    }
    return res;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
////////////////////////////////////////////////////////////////////////
//Решение задач с натуральными числами

/* Main();
void Main()
{
   int Size = PromptA();                               //Вызов метода ввода размера массива
   int start = PromptB();                              //Вызов метода ввода начала массива                         
   int end = PromptC();                                //Вызов метода ввода конца массива
   int[] array = GetArray(Size, start, end);
   //int[] array = GetArray(5, 1, 10);
   Console.Write($"Наш массив: ");
   PrintArray(array);                                  //Вывод массива на экран
   MinMax(array);                                      //метод нахождения разницы между макс и миним элементами массива 
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


int MinMax(int[] array)
{
   int maxEl = array[0];
   int minEl = array[0];
   int Diff = 0;
   for (int i = 0; i < array.Length; i++)
   {
       if (array[i] > maxEl)
       {
           maxEl = array[i];
       }
       if (array[i] < minEl)
       {
           minEl = array[i];
       }

   }
   Diff = maxEl - minEl;
   Console.WriteLine($"Разница между максимальным и минимальным числом = {Diff}.");
   return Diff;
}
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
*/
