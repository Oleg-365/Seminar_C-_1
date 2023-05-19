﻿//Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.



void Initialized(int[] a)
{
    for(int i=0; i<a.Length; i++)
    {
        a[i]=new Random().Next(0,2);
    }
}

void Write(int[] a)
{
    for(int i=0; i<a.Length; i++)
    {
        Console.Write(a[i]+" ");
    }
}

int[] a={1, 1, 1, 1, 1, 1, 1, 1};
Initialized(a);
Write(a);

// Вариант решения
 
// int[] SumArr(int[] array1, int[] array2)
//{
//    int[] resArray = new int[array1.Length];
//    for (int i = 0; i < resArray.Length; i++)
//    {
//        resArray[i] = array1[i] + array2[i];
//    }
//    return resArray;
//}

//int[] RandArr(int num)
//{
//    int[] array = new int[num];
//    for (int i = 0; i < num; i++)
//    {
//        array[i] = new Random().Next(0, 2);
//    }
//    return array;
//}

//void PrintArr(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write($" [{array[i]}] ");
//    }
//    Console.WriteLine();
//}

//const int lengthArr = 8;

//int[] arr1 = RandArr(lengthArr);
//int[] arr2 = RandArr(lengthArr);
//PrintArr(arr1);
//PrintArr(arr2);
//PrintArr(SumArr(arr1, arr2));
