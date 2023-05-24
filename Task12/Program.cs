﻿//Пример идеального решения Д.з по семинару 2
//Задача 1: Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа.
// Пример:
//456 -> 5
//782 -> 8
//918 -> 1

int Promt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt("Введите трёхзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}

Console.WriteLine($"Введенное число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");