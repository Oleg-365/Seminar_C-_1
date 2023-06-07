/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.Write("Введите число M: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write($"Промежуток от M до N: ");
SizeNumber(number, start);
Console.WriteLine();

Console.Write($"Сумма натуральных элементов в промежутке от М до N = {SumNumber(start, number)}.");

int SizeNumber(int number, int start)
{
    if (start <= number)
    {
        Console.Write($"{start}  ");
        return SizeNumber(number, start + 1);
    }
    return start;
}

int SumNumber(int start, int number)
{
    int sum = 0;
    if (start == number)
    {
        return start;
    }
    else
    {
        sum = start + SumNumber(start+1, number);
    }
    return sum;
}