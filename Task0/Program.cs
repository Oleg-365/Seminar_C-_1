﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
//на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

Console.Write("Введите число: "); //Подсказка для пользователя
int number = int.Parse(Console.ReadLine()!); //Работа с пользователем, получаем число
int sqr= number * number; //Вычисление квадрата этого числа
Console.WriteLine ("Квадрат нашего числа = " + sqr); //Вывод результатов, склейка сообщения плюс результат

