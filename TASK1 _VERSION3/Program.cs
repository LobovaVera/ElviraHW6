// нехороший метод решения задачи
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
        bool checkForEnd = int.TryParse(str, out int checkedNumber);//если число - попадаем в if, если не число попадаем в else

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

