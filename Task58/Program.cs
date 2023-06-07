/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.Clear();

Console.Write("Enter a numberN: ");
int number = int.Parse(Console.ReadLine()!);
int start = 1;
SizeNumber(number, start);

int SizeNumber(int number, int start)
{
    if (start <= number)
    {
        Console.Write($"{number} " );
        return SizeNumber(number - 1, start);
    }
return number;
}