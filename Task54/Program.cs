/*Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

Console.Clear();
Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine()!);
int start = 1;

Console.Write($" ");
SizeNumber(number, start);

void SizeNumber(int number, int start)
{
    if (start <= number)
    {
        Console.Write($"{start}  ");
        SizeNumber(number, start + 1);
    }
}



