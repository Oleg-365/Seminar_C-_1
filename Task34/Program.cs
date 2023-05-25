//Задача 40: Напишите программу, которая принимает на
//вход три числа и проверяет, может ли существовать
//треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.

//Console.WriteLine("Hello, World!");

int[] GetLines(int size, int minVale, int maxVale)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVale, maxVale + 1);
    }

    return array;
}

bool isTriangle(int[] linesArray)
{
    if ((linesArray[0] < linesArray[1] + linesArray[2]) &&
        (linesArray[1] < linesArray[0] + linesArray[2]) &&
        (linesArray[2] < linesArray[1] + linesArray[0]))
        return true;
    else
        return false;
}

int [] array = GetLines(3, 1, 5);
Console.WriteLine(String.Join(" ", array));
if (isTriangle(array)) 
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

