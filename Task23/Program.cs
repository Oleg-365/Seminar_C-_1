//Задача 25: Напишите программу, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

class program
{
    static Main();
   
    void Main()
    {
        PromtA();
        PromtB();
        Degree (userNumA, userNumB);
    //Console.WriteLine
    }
 
    int PromtA()
    {
        Console.Write("Введите первое число: ");
        int userNumA = int.Parse(Console.ReadLine()!);
        return userNumA; 
    }
    int PromtB() 
    {  
    Console.Write("Введите второе число: ");
    int userNumB = int.Parse(Console.ReadLine()!);
    return userNumB;
    }

        double Degree (int userNumA, int userNumB)
    {
        double numer = userNumA;
        int stepen = Convert.ToInt32(userNumB);
    
    //if (numer>0 && stepen>0)
    //{
       int temp = Convert.ToInt32 (Math.Pow(numer, stepen));
        return temp;
    }
    
}
    //else
    //Console.WriteLine($"{numer}^{stepen} ="  + Math.Pow(numer, stepen));
    //Console.WriteLine("5^4 = " + Math.Pow(5, 4));
    //Console.WriteLine("-5^4 = " + Math.Pow(-5, 4));
    //Console.WriteLine("-5^(-4) = " + Math.Pow(-5, -4));;
    //return result;
 //}
    

 
