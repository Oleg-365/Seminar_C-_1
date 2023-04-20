//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Vvedite chislo 3 ili 5: ");
int number = int.Parse(Console.ReadLine()!); //Введите число
if (number == 3)
 {
     Console.WriteLine ("День недели - Среда");
 }
 else if(number ==5)
 {
     Console.WriteLine ("День недели - Пятница");
 }