/*

int[] EnterSomeNumbers(int i, int[] array)//вводим число, записываем в массивб если не число - завершаем.
{


    Console.WriteLine($"\nВведите целое число, если Вы закончили ввод, наберите 'Завершить' i = {i}");
    string str = Console.ReadLine()!;
    bool checkForEnd = int.TryParse(str, out int checkedNumber);//если число - попадаем в иф, если не число попадаем в элс
 Console.WriteLine("the array inside the method");//внутри метода массив записался
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
        PrintArray(array);
       EnterSomeNumbers(i, array);//рекурсия - чтобы записывать числа, пока пользователю не надоест
        
    }
    else
    {
        Console.WriteLine("Ввод данных завершен");
    

    }


   return array;

}



void PrintArray(int[] arr)
{
    Console.Write($" \n Array:");
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
     Console.Write($" \n the array outside the method:");//снаружи метода массив записал только первое значение
 PrintArray(arrayOfYourNumbers);

}
Main(); */
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        int[] arr = new int[0];
        EnterSomeNumbers(ref arr);
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        Console.Write($" \n Array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"\n {arr[i]} ");
        }
    }

    static void EnterSomeNumbers(ref int[] array)//вводим число, записываем в массивб если не число - завершаем.
    {
        Console.WriteLine($"\nВведите целое число, если Вы закончили ввод, наберите 'Завершить'");
        string str = Console.ReadLine()!;
        bool checkForEnd = int.TryParse(str, out int checkedNumber);//если число - попадаем в иф, если не число попадаем в элс

        if (checkForEnd)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = checkedNumber;
            EnterSomeNumbers(ref array);//рекурсия - чтобы записывать числа, пока пользователю не надоест
        }
        else
        {
            Console.WriteLine("Ввод данных завершен");
        }
    }
}