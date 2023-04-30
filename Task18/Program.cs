// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int n = Promt("Введите число N: ");
NumTable(n);

int Promt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    int numN = Convert.ToInt32(value);
    return Math.Abs(numN);
}

void NumTable(int n)
{
    int currentNum = 1;
    int sqr = 1;
    while (currentNum <= n)
    {
        sqr = currentNum * currentNum;
        Console.WriteLine(sqr);
        currentNum++;
    }
}