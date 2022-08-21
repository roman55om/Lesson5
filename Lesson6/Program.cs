//_____________Tasks recall block_________
//________________________________________
//________________________________________
void Task39()
{
    //39. Write a program that turns the array around.
    int size = 9;
    int[] array = new int[size];

    FillArray(array, 1, 10);
    PrintArray(array);
    NewReverseArrayCortage(array);
    PrintArray(array);
}

void Task40()
{
    //40. Write a program that takes 3 input numbers and checks
    // if a triangle with those side lengths can exist.

    Console.WriteLine($"Enter the side A length that is more than 0");
    float sideALength = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"Enter the side B length that is more than 0");
    float sideBLength = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"Enter the side C length that is more than 0");
    float sideCLength = Convert.ToInt32(Console.ReadLine());

    if (sideALength+sideBLength > sideCLength && sideBLength+sideCLength > sideALength && sideALength + sideCLength > sideBLength)
    {
        Console.WriteLine("A triangle exists");
    }

    else {Console.WriteLine("The triangle does not exist.");}
}

void Task42()
{
    //42. Write a program that converts a decimal number
    // to a binary number.

    int number = 41;
    int result = 0;
    int bias = 1;
    
    while (number > 0)
    {
        result = result + number%2 * bias;
        bias *= 10;
        number /= 2;
    }

    Console.WriteLine(result);
}

void Task44()
{
    //44. Write a program that shows first N Fibonacci
    // numbers. The first ones are 0 and 1.

    Console.WriteLine("Enter the N number:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int i = 0;
    array[i] = 0;
    array[i+1] = 1;

    while (i<size-2)
    {
        array[i+2] = array[i]+array[i+1];
        i++;
    }
    PrintArray(array);
}

void Task45()
{
    //45. Write a program that creates a copy of array by
    // elemental copying.

    int size = 6;
    int[] array = new int[size];
    int[] newArray = new int[array.Length];
    
    FillArray(array);
    PrintArray(array);
    CopyArray(array, newArray);
    PrintArray(newArray);
}

void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. 
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.WriteLine("Enter the total amount of numbers (M) you are about to set:");
    int m = Convert.ToInt32(Console.ReadLine());
    CountNumThatMoreThat0 (m);

    // int countMoreThan0 = 0;
    // for (int i = 0; i<m; i++)
    // {
    //     Console.WriteLine("Enter the next number:");
    //     int number = Convert.ToInt32(Console.ReadLine());
    //     if (number > 0) countMoreThan0 ++;
    // }
    // Console.WriteLine($"There are {countMoreThan0} numbers > 0 ");


}

void Task43()
{
    // 43. Напишите программу, которая найдёт точку 
    // пересечения двух прямых, 
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    // значения b1, k1, b2 и k2 задаются пользователем.

    Console.WriteLine("The first straight is set with the equation y = k1 * x + b1");
    Console.WriteLine("Enter k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter b1");
    double b1 = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("The second straight is set with the equation y = k2 * x + b2");
    Console.WriteLine("Enter k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter b2");
    double b2 = Convert.ToInt32(Console.ReadLine());

    FindStraightsCrossingDot(k1,k2,b1,b2);
    // if (k1 == k2) Console.WriteLine("K1 = K2 - Wrong values");
    // else
    // {
    //     double x = (b2-b1) / (k1-k2);
    //     double y = k2 * x + b2;
    //     Console.WriteLine($"{x}, {y}");
    // }


}
//___________Auxiliary method block_______
//________________________________________
//________________________________________
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber ++;
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void ReverseArray(int[] array)
{
    int size = array.Length;
    int halfSize = size/2;
    int maxIndex = size - 1;
    int help = 0;
    for (int i = 0; i<halfSize; i++)
    {
        help = array[i];
        array[i] = array[maxIndex];
        array[maxIndex] = help;
        maxIndex--;
    }
}

void NewReverseArrayCortage(int[] array)
{
    int size = array.Length;
    int halfSize = size/2;
    int maxIndex = size - 1;
    for (int i = 0; i<halfSize; i++)
    {
        (array[i], array[maxIndex - i]) = (array[maxIndex - i], array[i]);
    }
}

void SetTriangleSideLength()
{
    Console.WriteLine($"Enter the side A length that is more than 0");
    float sideALength = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"Enter the side B length that is more than 0");
    float sideBLength = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"Enter the side C length that is more than 0");
    float sideCLength = Convert.ToInt32(Console.ReadLine());
    
}

void CopyArray(int[] arrayOriginal, int[] arrayCopy)
{
    int size = arrayOriginal.Length;
    for (int i = 0; i < size; i++)
    {
        arrayCopy[i] = arrayOriginal[i];
    }
    
}

void CountNumThatMoreThat0 (int m)
{
    int countMoreThan0 = 0;
    for (int i = 0; i<m; i++)
    {
        Console.WriteLine("Enter the next number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) countMoreThan0 ++;
    }
    Console.WriteLine($"There are {countMoreThan0} numbers > 0 ");
}

void FindStraightsCrossingDot (double k1, double k2, double b1, double b2)
{
    if (k1 == k2) Console.WriteLine("K1 = K2 - Wrong values");
    else
    {
        double x = (b2-b1) / (k1-k2);
        double y = k2 * x + b2;
        Console.WriteLine($"{x}, {y}");
    }
}

//___________Main code____________________
//________________________________________
//________________________________________
