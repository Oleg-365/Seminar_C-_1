//Задача 25: Напишите программу, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Main();


int Promt()
{
    Console.Write("Введите первое число: ");
    Console.Write("Введите второе число: ");
    int userNumA = int.Parse(Console.ReadLine()!);
    int userNumB = int.Parse(Console.ReadLine()!);
    return userNumA; userNumB;
}
//int PromtB()
//{
   // Console.Write("Введите второе число: ");
   // int userNumB = int.Parse(Console.ReadLine()!);
    //return userNumB;
//}

 double degree (int userNumA, int userNumB)
 {
    double numer = userNumA;
    int stepen = Convert.ToInt32(userNumB);
    //if (numer>0 && stepen>0)
    {
        Console.WriteLine($"{numer}^{stepen} ="  + Math.Pow(numer, stepen));
    }
    //else
    //Console.WriteLine("5^4 = " + Math.Pow(5, 4));
    //Console.WriteLine("-5^4 = " + Math.Pow(-5, 4));
    //Console.WriteLine("-5^(-4) = " + Math.Pow(-5, -4));;
    //return result;
 }
    

 
