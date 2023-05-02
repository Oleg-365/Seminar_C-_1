//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//Например:
//78 -> 8
//12-> 2
//85 -> 8

Main();

void Main()
{
    int rand = new Random().Next(10, 100);
    Console.WriteLine("Рамдомное число:  " + rand);
    int a1 = FindFirstDigitNumber(rand); //первая цифра рандомного числа.
    int b1 = FindSecondDigitNumber(rand); //последняя цифра рандомного числа.
    FindLargesNumber(a1, b1);

    int rand1 = new Random().Next(10, 100);
    Console.WriteLine("Рамдомное число:  " + rand1);
    int a2 = FindFirstDigitNumber(rand1); //первая цифра рандомного числа.
    int b2 = FindSecondDigitNumber(rand1); //последняя цифра рандомного числа.
    FindLargesNumber(a2, b2);

}

void FindLargesNumber(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine("Наибольшее цифра числа = " + a);
    }
    else if (a < b)
    {
        Console.WriteLine("Наибольшее цифра числа = " + b);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}
int FindFirstDigitNumber(int r)
{
    int result = r / 10;
    return result;
}

int FindSecondDigitNumber(int r)
{
    int result = r % 10;
    return result;
}