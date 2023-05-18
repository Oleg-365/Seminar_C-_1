//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int Promt()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Number(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}

int num = Promt();
Console.WriteLine($"Количество цифр в числе {num} равно  {Number(num)}");