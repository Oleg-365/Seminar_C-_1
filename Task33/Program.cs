//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

Console.Clear();
int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join("|", array));
ReversArray1(array);
Console.WriteLine(String.Join("|", array));
int[] revers = ReversArray2(array);
Console.WriteLine(String.Join("|", array));

int[] GetArray(int size,int minValue,int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size;i++){
        res[i] = new Random().Next(minValue, maxValue);

    }
    return res;
}
void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2;i++){
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = k;
    }
}

int[] ReversArray2(int[] inArray)
{
        int[] res = new int[inArray.Length];
        for (int i = 0; i < inArray.Length;i++){
            res[i] = inArray[inArray.Length - 1 - i];
        }
    return res;
}