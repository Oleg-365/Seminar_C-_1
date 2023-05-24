/* int[,] pic = new int[,]
// в записе записанной выше дан массив в лекции это знак "класс"

void PrintImage(int[,] image) // метод вывода массива
{
    for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) где 0 это количество строк в даннм случае 3.
    {
        for (int j = 0; j < matr.GetLength(1); j++)  ////matrix.GetLength(1) где 1 это количество строк в даннм случае 4.
        {
            // Console.Write($"{matr[i, j]} ");
            if (image[i, j] == 0) Console.WriteLine($" ");
            else Console.WriteLine($"+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col) // метод закрашивания
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row - 1, col - 1);
        FillImage(row + 1, col);
        FillImage(row - 1, col + 1);
    }
}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic); */