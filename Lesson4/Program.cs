//
string[,] table = new string[2, 5]; //где 5 индекс меняется от 0 до 4
//Инициализация происходит спомощью команды:
//String.Empty
// table[0,0] table[0,1] table[0,2] ... table[0,4]
// table[1,0] table[1,1] table[1,2] ... table[1,4]


//table[1, 2] = "Слово";

//for (int rows = 0; rows < 2; rows++)
//{
//   for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{ table [rows, columns]}-");
//    }
//}

//int[,] matr - запись двумерного массива

void PrintArray(int[,] matr) // метод вывода массива
{
    for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) где 0 это количество строк в даннм случае 3.
    {
        for (int j = 0; j < matr.GetLength(1); j++)  ////matrix.GetLength(1) где 1 это количество строк в даннм случае 4.
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // метод заполнения массива
{
for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)  
        {
            matr[i,j]= new Random().Next(1,10); // полуинтерва от 1 до 10 но десять не входит
        }
        
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix); //Вызов метода расстановки
FillArray(matrix); ////Вызов метода заполнения
Console.WriteLine();
PrintArray(matrix); 
