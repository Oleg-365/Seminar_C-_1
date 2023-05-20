//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Main();

void Main()
{
    int number = Promt();
    Validate(number);
    Sum(number);
}

int Promt()
{
    Console.Write("Введите от 11 до 9999 число: ");
    int Num = int.Parse(Console.ReadLine()!);
    return Num;
}

int Validate(int Num)
{
    if (Num >= 11 || Num <= 9999)
    {
        return Num;
    }
    else
    {
        Console.Write("Вы ввели неверное число");
    }
}
int Summa(int Num)
{

}