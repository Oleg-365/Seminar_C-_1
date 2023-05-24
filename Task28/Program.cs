//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число - ");
int Number = int.Parse(Console.ReadLine()!);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[10];
    for (int i = 0; i < 10; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(10, 0, 10);

Console.WriteLine(" ");

GetSum(array);

void GetSum(int[] arr)
{
    foreach (int el in arr)
    {
        if (el==Number)
        {
            Console.WriteLine("Да");
            return;
        }
    }
    Console.WriteLine("Нет");
}

// Другой способ решения задачи

//int[] GetArray(int size, int minValue, int maxValue)
//{
 //   int[] res = new int[size];
 //   for (int i = 0; i < size; i++)
 //   {
 //       res[i] = new Random().Next(minValue, maxValue + 1);
 //       //Console.Write($"{res[i]} ");
 //   }
 //   return res;
//}

//void CheckNumArr(int[] arr, int num)
//{
  //  bool check = false;
 //   num = Math.Abs(num);
 //   foreach (int el in arr)
  //  {
 //       if (el == num)
 //       {
 //           Console.WriteLine($"{num}; массив [ {String.Join(" ", arr)} ] -> да");
 //          check = true;
 //           break;
 //       }
  //  }
  //  if (check == false)
  //  {
  //      Console.WriteLine($"{num}; массив [ {String.Join(" ", arr)} ] -> нет");
 //   }
//}

//int[] array = GetArray(10, -10, 10);
//Console.WriteLine();
//CheckNumArr(array, -4);