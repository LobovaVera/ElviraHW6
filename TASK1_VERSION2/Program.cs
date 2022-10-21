//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


 Console.WriteLine($"\nВведите целое число, если Вы закончили ввод, наберите 'Завершить'");
    string str = Console.ReadLine()!;
   bool checkForEnd = int.TryParse(str, out int checkedNumber);
    int count = 0;
    
 while(checkForEnd)
 {
    
    Console.WriteLine($"\nВведите целое число номер {count}, если Вы закончили ввод, наберите 'Завершить'");
    str = Console.ReadLine()!;
    checkForEnd = int.TryParse(str, out int checkedNum);
    if (checkedNum>0)
    {
        count++;
    }
 }

 Console.WriteLine($"Ввод данных завершен, количество чисел больше нуля равно {count}");


/* еще вариант, который не получился

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
        PrintArray(array);*/
       /* EnterSomeNumbers(i, array);//рекурсия - чтобы записывать числа, пока пользователю не надоест
        
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
Main();*/