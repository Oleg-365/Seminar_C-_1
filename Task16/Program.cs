// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int quarter = Promt("Введите номер четверти: ");
FindDiap(quarter);

void FindDiap(int quart)
{
    if (quart == 1)
    {
        Console.WriteLine("Диапазон X от 0 до inf");
        Console.WriteLine("Диапазон Y от 0 до inf");
    }

    if (quart == 2)
    {
        Console.WriteLine("Диапазон X от 0 до inf");
        Console.WriteLine("Диапазон Y от 0 до -inf");
    }

    if (quart == 3)
    {
        Console.WriteLine("Диапазон X от 0 до -inf");
        Console.WriteLine("Диапазон Y от 0 до -inf");
    }
    if (quart == 4)
    {
        Console.WriteLine("Диапазон X от 0 до -inf");
        Console.WriteLine("Диапазон Y от 0 до inf");
    }
}

int Promt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    int findQuarter = Convert.ToInt32(value);
    return findQuarter;
}