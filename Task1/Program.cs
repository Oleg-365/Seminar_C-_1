﻿//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

int a = int.Parse(Console.ReadLine()!); //Введите первое число
int b = int.Parse(Console.ReadLine()!); //Введите второе число

if (b*b==a)
{
    Console.WriteLine("Da");
}
else
{
    Console.WriteLine("Net");
}
