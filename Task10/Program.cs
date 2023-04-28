//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int rand = new Random().Next(100, 1000);

Console.WriteLine("Рамдомное число:  " + rand);
Console.WriteLine(" " + rand);

FistNumber(rand);

int FistNumber(int x)
{
    int a = x / 100;
    int b = x % 10;
    rand = (a * 10) + b;
    return x;
}

