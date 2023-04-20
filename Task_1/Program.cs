//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA % 100 == ((numA /1000)+9))
{
   Console.WriteLine("{0} Палиндром" , numA);
}
else 
{
    Console.WriteLine("{0} Не палиндром", numA);
}

