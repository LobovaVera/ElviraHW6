﻿//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/



int[] EnterSomeNumbers(int i, int[] array)//вводим число, записываем в массивб если не число - завершаем.
{


    Console.WriteLine($"\nВведите целое число, если Вы закончили ввод, наберите 'Завершить' i = {i}");
    string str = Console.ReadLine()!;
    bool checkForEnd = int.TryParse(str, out int checkedNumber);
 //   Console.WriteLine("Print1");
    PrintArray(array);

    if (checkForEnd)
    {
        checkedNumber = int.Parse(str);
        Array.Resize(ref array, array.Length + 1);
        array[i] = checkedNumber;
       // int size = array.Length;
        //Console.WriteLine($" \n arr i = {array[i]} arr length = {size} number {i} is {checkedNumber}");
        i++;
        /*Console.WriteLine("Print2");
        PrintArray(array);*/
        EnterSomeNumbers(i, array);
    }
    else
    {
        Console.WriteLine("Ввод данных завершен");

    }


    return array;

}



void PrintArray(int[] arr)
{
    Console.Write($" \n ваши числа:");
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"\n {arr[i]} ");
    }
}


void Main()
{
    int a = 0;
    int[] array = new int[0];
    int[] arrayOfYourNumbers = EnterSomeNumbers(a, array);
 PrintArray(arrayOfYourNumbers);

}
Main();