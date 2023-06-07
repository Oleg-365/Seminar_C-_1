/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

int a = Prompt("Введите число A: "); 
int n = Prompt("Введите число N: "); 
Console.Write(PowerRecV2(a, n)); 
 
int Prompt(string message) 
{ 
    Console.Write(message); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value; 
} 
 
int PowerRecV2(int numA, int numN) 
{ 
    if (numN == 0) return 1; 
    else return PowerRecV2(numA, numN - 1) * numA; 
}