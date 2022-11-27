/*
Используя определение степени числа,
напишите цикл, который принимает на вход два
натуральных числа (A и B) и возводит число A в степень B.
*/
void Zadacha25()
{
    Random rand = new Random();
    int numberA = rand.Next(1, 16);
    int numberB = rand.Next(1, 16);
    Console.WriteLine("Число А: " + numberA + ". Число В: " + numberB);

    int count = 1;
    int stepen = 1;
    while (count <= numberB)
    {
        stepen *= numberA;
        count++;
    }
    Console.WriteLine(stepen); 
}

Zadacha25();

