/*
Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12
*/

void Zadacha27()
{
    Random rand = new Random();
    int number = rand.Next(1, 10);
    Console.WriteLine("Число: " + number);

    string numberStr = Convert.ToString(number);

    int sum = 0;
    for(int i = 0; i < numberStr.Length; i++)
    {
        sum += numberStr[i];
    }
    Console.WriteLine(sum); // не могу понять почему тут результат выходит не верный
}
Zadacha27();

