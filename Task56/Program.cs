/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9*/

Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write(SumNumbers(number));


int SumNumbers(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number%10 + SumNumbers(number/10);  
}


