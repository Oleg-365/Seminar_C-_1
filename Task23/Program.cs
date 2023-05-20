//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16



Main();

void Main()
{
    int numberA = PromtA();
    int numberB = PromtB();
    Degree(numberA, numberB);
}
int PromtA()
{
    Console.Write("Введите первое число: ");
    int NumA = int.Parse(Console.ReadLine()!);
    return NumA;
}
int PromtB()
{
    Console.Write("Введите второе число: ");
    int NumB = int.Parse(Console.ReadLine()!);
    return NumB;
}

void Degree(int NumA, int NumB)
{
    int number = NumA;
    int stepen = NumB;
    int temp = 1;

    if (stepen < 1)
    {
        Console.WriteLine($"Число {stepen} должно быть натуральным");
    }
    else
    {
        //int step = 1;
        //for (int i = 1; 1 <= stepen; i++)
        //{
        //  step = step * number;
        //}

        while (stepen != 0)
        {
            temp = temp * number;
            stepen = stepen - 1;
        }
        Console.Write($"Число {number} в натуральной степени {NumB} равно {temp}");
    }

    //return step;
}

//temp = Convert.ToInt32 (Math.Pow(numer, stepen));

//Console.WriteLine($"{numer}^{stepen} =" + Math.Pow(numer, stepen));
//else
//Console.WriteLine($"{numer}^{stepen} ="  + Math.Pow(numer, stepen));
//Console.WriteLine("5^4 = " + Math.Pow(5, 4));
//Console.WriteLine("-5^4 = " + Math.Pow(-5, 4));
//Console.WriteLine("-5^(-4) = " + Math.Pow(-5, -4));;
//return result;
//}



