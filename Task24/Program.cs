//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Main();

void Main()
{
    int number = Promt();
    int len = NumberLen(number);
    Validate(number);
    Sum (number, len);
    Console.Write($"Сумма цифр числа {number} составляет {Sum (number, len)}.");
}

int Promt()
{
    Console.Write("Введите число не меньше 11: ");
    int Num = int.Parse(Console.ReadLine()!);
    return Num;
}

int Validate(int Num)
{
    if (Num >= 11)
    {
        return Num;
    }
    else
    {
        Console.Write("Вы ввели неверное число! Введите число не меньше 11! ");
    }
    return Num;
}

int NumberLen (int Num)
{
    int index = 0;
    while (Num>0)
{
    Num/=10;
    index++;
}
    return index;
}

int Sum (int Num, int length)
{
   int Summa = 0;
    for (int index = 0; index < length; index++)
    {
    Summa += Num%10;
    Num/=10;
    }
    return Summa;
}

//int Summa(int Num)
//{
    //int Sum = 0;
   // int Summa1 = 0;
   // int Summa2 = 0;
   // int Summa3 = 0;
   // Sum = Summa1 + Summa2 + Summa3;

   // if (Num >= 11 || Num < 99)
   // {
   //     int tempC = Num / 10;
  //      int tempD = Num % 1;
   //     int Sum1 = 0;
  //      Sum1 = tempC + tempD;
   //     return Sum1;
   // }
  //  else if (Num >= 100 || Num < 999)
   // {
   //     int tempB = Num / 100;
   //     int tempC = Num / 10;
  //      int tempD = Num / 1;
   //     int Sum2 = 0;
  //      Sum2 = tempB + tempC + tempD;
   //     return Sum2;
   // }
   // else if (Num >= 1000 || Num < 9999)
   // {
   //     int tempA = Num / 1000;
  //      int tempB = Num / 100;
   //     int tempC = Num / 10;
   //     int tempD = Num / 1;
   //     int Sum3 = 0;
   //     Sum3 = tempA + tempB + tempC + tempD;
   //     return Sum3;
   // }
//return Sum;
//}