

int x1 = Promt("Введите координату Xa: ");
int y1 = Promt("Введите координату Ya: ");
int x2 = Promt("Введите координату Xb: ");
int y2 = Promt("Введите координату Yb: ");

double d = FindLength(x1, y1, x2, y2);

double FindLength(int xa, int ya, int xb, int yb)
{
    double result = Convert.ToDouble(Math.Round(Math.Sqrt(((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya))),3));
    Console.Write(result);
    return result;
}

int Promt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    int coord = Convert.ToInt32(value);
    return coord;
}
