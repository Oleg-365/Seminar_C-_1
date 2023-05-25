//Задача 42: Напишите программу, которая будет
//преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

string ToBinary(int number)
{
    string binary = String.Empty;
    while (number > 0)
    {
        binary = (number % 2).ToString() + binary;
        number = number / 2;
    }

    return binary;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{number} -> {ToBinary(number)}");