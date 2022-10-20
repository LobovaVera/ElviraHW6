//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

void Main()
{
    int M = 5;
    int[] ourNumbers = new int[M];
    for (int i = 0; i<M; i++)
    {
        ourNumbers[i] = EnterDigit();
        
    }
    PrintArray(ourNumbers);
    CountPositiveNumbers(ourNumbers);
}

int EnterDigit()
{
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void CountPositiveNumbers(int[] arr)
{
    int count = 0;
    foreach(int el in arr)
    {
        if (el>0)
        {
            count++;

        }
    }
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}

Main();
