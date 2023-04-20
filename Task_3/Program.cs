//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()?? " ");
int count = 1;
int res = 0;
while (count <= num)
{
    res = count * count * count;
    Console.WriteLine($"{count}^3 = {res}");
    count++; 
}



