//Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.



void Initialized(int[] a){
    for(int i=0; i<a.Length; i++)
    {
        a[i]=new Random().Next(0,2);
    }
}

void Write(int[] a)
{
    for(int i=0; i<a.Length; i++)
    {
        Console.Write(a[i]+" ");
    }
}

int[] a={1, 1, 1, 1, 1, 1, 1, 1};
Initialized(a);
Write(a);