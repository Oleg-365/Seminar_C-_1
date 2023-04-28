//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//Пример:
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

Console.Write("Enter a number 1: ");

int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number 2: ");

int numberB = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number 3: ");

int numberC = int.Parse(Console.ReadLine()!);

int max = numberA;

if (numberB < max && numberC < max)
{
    Console.WriteLine("max = " + numberA);
}
else
{
    if (numberB < numberC)
    {
        Console.WriteLine("max = " + numberC);
    }
    else
    {
        Console.WriteLine("max = " + numberB);
    }
}

