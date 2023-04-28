//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int rand = new Random().Next(10, 50);
Console.WriteLine("Рамдомное число:  " + rand);

int rand1 = new Random().Next(1, 10);
Console.WriteLine("Рамдомное число:  " + rand1);

 NumberX(rand, rand1);

void NumberX(int x,int y)
{
    if (x % y == 0)
    {
        Console.WriteLine("Число кратно");
    }
    else
    {
        Console.WriteLine("Число не кратно, остаток: " + (x % y));
    }
}
