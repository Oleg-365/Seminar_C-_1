// Задача 45: Напишите программу, которая будет
//создавать копию заданного массива с помощью
//поэлементного копирования.


Console.Clear();
int n = Prompt("Введите размер массива: ");
int[] array = GetArray(n);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine(String.Join(", ", CopyArray(array)));



int Prompt(string messege)

{
    Console.Write(messege);
    int Number = int.Parse(Console.ReadLine());
    int findQuarter = Convert.ToInt32(Number);
    return findQuarter;
}

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 40);
    }
    return res;
}

int[] CopyArray(int[] arr)
{

    int[] array1 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array1[i] = arr[i];
    }
    return array1;
}
