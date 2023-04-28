//Задача №2
//Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
//Пример:
//a = 5; b = 7 -> max = 7
//а = 2; b = 10 -> max = 10
//а = -9; b = -3-> max = -3

Console.Write("Enter a number 1: ");

int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number 2: ");

int numberB = int.Parse(Console.ReadLine()!);

int max = numberA;

if (numberB < max)
{
    Console.WriteLine("min = " + numberB);
    Console.WriteLine("max = " + numberA);
}
else
{
    Console.WriteLine("min = " + numberA);
    Console.WriteLine("max = " + numberB);
}

