//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Main();

void Main()
{
    Console.Clear();
    Prompt("Введите элементы(через пробел): ");

    int[] array = Transformation();
    GetArray(array);

}



int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] Transformation()
{
    int number = value;
    string str = a.ToString();
    int[] b = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        b[i] = int.Parse(str[i]);
    }
    //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    //int number = value;
    //var array = number.ToString().Select(e => int.Parse).ToArray();
    //var array = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();

    //  foreach (var item in array)
    //  {
    //      Console.WriteLine(item);
    //  }

    //  Console.ReadLine();
    return b[i];
}

void GetArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во элементов > 0: {count}");
}







//Console.Write("Введите элементы(через пробел): ");
//int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


