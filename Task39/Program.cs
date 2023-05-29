//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




Main();

void Main()
{
    Console.Clear();
    double b1 = Prompt("Введите значение b1: ");
    double k1 = Prompt("Введите значение k1: ");
    double b2 = Prompt("Введите значение b2: ");
    double k2 = Prompt("Введите значение k2: ");
    double X = IntersectionOfLines1(b1, k1, b2, k2);
    double Y = IntersectionOfLines2(b1, k1, b2, k2);
    Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {X}, Y: {Y}");
}

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double IntersectionOfLines1(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    return x;
}

double IntersectionOfLines2(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    return y;
}