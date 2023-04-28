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