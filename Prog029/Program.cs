/*
Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

-2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
6, 1, -33 -> [1, 6, -33]
*/

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for(int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-10, 10);
    }
}

void PrintArray(int[] nums)
{
    int size = nums.Length;
    for(int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] nums)
{    
    for (int i = 0; i < nums.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < nums.Length; j++)
        {
            if(nums[j] < nums[minPosition]) minPosition = j;
        }

        int temporary = nums[i];
        nums[i] = nums[minPosition];
        nums[minPosition] = temporary;
    }
}


void Zadacha29()
{   
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    SelectionSort(numbers);
    PrintArray(numbers);
}
// не поняла, как упорядочить по модулю, без учета знака
Zadacha29();