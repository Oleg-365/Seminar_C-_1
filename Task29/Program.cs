/*Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


internal partial class Program_4
{
    private static void Main(string[] args)
    {
        int[] GetArray(int size, int minValue, int maxValue)
        {
            int[] res = new int[size];
            for (int i = 0; i < size; i++)
            {
                res[i] = new Random().Next(minValue, maxValue + 1);
            }
            return res;
        }

        void printArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

        int[] sumArray(int[] array)
        {
            int newLength = (int)Math.Ceiling(array.Length / 2.0);
            int[] newArray = new int[newLength];
            
            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = array[i] * array[array.Length - 1 - i];
            }

            if (newLength % 2 != 0)
            {
                newArray[newLength - 1] = array[array.Length / 2];
            }

            return newArray;
        }

        int[] array = GetArray(5, 1, 5);
        printArray(array);
        int[] newArray = sumArray(array);
        printArray(newArray);
    }
}
///////////////////////////////////////////////////////////
//int[] GetArray(int size, int minValue, int maxValue)
//{
 //   int[] res = new int[size];
 //   for (int i = 0; i < size; i++)
 //   {
 //       res[i] = new Random().Next(minValue, maxValue + 1);
 //       Console.Write($"{res[i]} ");
 ///   }
 //   return res;
//}

//void ProductArrayNum(int[] arr)
//{
 //   int[] createArr = new int[arr.Length];
//    int maxNum = arr.Length - 1;
//    for (int i = 0; i <= maxNum / 2; i++)
 //   {
 //       createArr[i] = arr[i] * arr[maxNum - i];
 //       Console.Write($"{createArr[i]} ");
 ///   }
 //   if (arr.Length % 2 != 0)
 //   {
 //       createArr[createArr.Length - 1] = Math.Sqrt(createArr[createArr.Length - 1]);
 //   }
//}

//int[] array = GetArray(9, -10, 10);
//Console.WriteLine();
//ProductArrayNum(array);
