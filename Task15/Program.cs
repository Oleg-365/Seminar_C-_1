// Задача №17. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

/*Main();

void Main()
{

    int valueX = Promt("Введите координату X: ");
    int valueY = Promt("Введите координату Y: ");
    FindQuarterPlane(valueX, valueY);

}

int Promt(string message)
{
    Console.Write(message);
    int coordNumber = int.Parse(Console.ReadLine());
    return coordNumber;
}

void FindQuarterPlane(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("I четверть");
    }

    if (x > 0 && y < 0)
    {
        Console.WriteLine("II четверть");
    }

    if (x < 0 && y < 0)
    {
        Console.WriteLine("III четверть");
    }

    if (x < 0 && y > 0)
    {
        Console.WriteLine("IV четверть");
    }
}
*/