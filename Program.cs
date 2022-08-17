//_____________Tasks recall block_________
//________________________________________
//________________________________________
void Task29A()
{
    //29. Write a program that creates the array of 8 random numbers 
    // and returns the array sorted on modulus.

    int size = 8;
    int[] array = new int [size];

    FillArray(array, -10, 10);
    PrintArray(array);
    SortArray(array);
    PrintArray(array);
}

void Task31()
{
    //31. Set an array of 12 random elements
    // of [-9;9] diapasone. 
    // Find a sum of positive and negative elements.

    int size = 12;
    int[] arrayA = new int [size];

    FillArray(arrayA);
    PrintArray(arrayA);
    SumPositive(arrayA);
    SumNegative(arrayA);
}

void Task32()
{
    //32. Write a program that turns positive numbers
    // into negative and vice versa.

    int size = 8;
    int[] array = new int [size];
    FillArray(array);
    PrintArray(array);
    ChangePosNumToNeg(array);
    PrintArray(array);
}

void Task33A()
{
    //33. Set an array. Write a program that checks
    //if the number exists in it or not.

    int size = 8;
    int[] array = new int [size];
    FillArray(array, -100, 100);
    PrintArray(array);

    Console.WriteLine();
    Console.WriteLine("Enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    for (int i = 0; i < size && !flag; i++)
    {
        flag = array[i] == number;
    }
    if (flag) Console.WriteLine($"The number {number} exists in the array");
    else Console.WriteLine($"The number {number} doesn't exist in the array");

}

void Task35()
{
    //35. Set an array of 10 random numbers.
    //Write a program that checks the quantity of numbers
    // in the [10,99] interval.

    int size = 10;
    int[] array = new int [size];
    FillArray(array, -99, 99);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count ++;
    }
    Console.WriteLine(count);

}

void Task37A()
{
    //37.Write a program that calculates the multiplication
    // of pairs in the array 
    //(eg: first and last, 2nd and 2nd last).
    //The result pull into new array.

    int size = 9;
    int[] array = new int [size];
    FillArray(array, 1, 9);
    PrintArray(array);

    int i = 0;
    while (i < size-1)
    {
        int multiplication = array[i] * array[size-1];
        Console.Write(multiplication + ", ");
        size--; 
        i++;
    }

    if (i%2 == 0) Console.Write(array[i]);
}

void Task37B()
{
    int size = 9;
    int[] array = new int [size];
    FillArray(array, 1, 9);
    PrintArray(array);

    int halfSize = size/2;
    int maxIndex = size - 1;
    int[] result = new int [halfSize + size%2];
    for (int i = 0; i < halfSize; i++)
    {
        result[i] = array[i] * array[maxIndex-i];
        Console.WriteLine(array[i] * array[maxIndex-i]);
    }

    if (size % 2 == 1) 
    {
        result[halfSize] = array[halfSize];
        Console.WriteLine("Middle element: " + array[halfSize]);
    }

    PrintArray(result);
}    

void Task34()
{
    // Задача 34: Задайте массив заполненный случайными 
    // положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество 
    // чётных чисел в массиве.

    int size = 8;
    int[] array = new int [size];

    FillArray (array, 100, 999);
    PrintArray(array);
    CountEvenNumbers(array);
}

void Task36()
{
    // Задача 36: Задайте одномерный массив, заполненный 
    // случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.

    int size = 5;
    int[] array = new int [size];

    FillArray (array, -100, 100);
    PrintArray(array);

    int sumNumsOnOddPos = 0;

    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 1) sumNumsOnOddPos += array[i]; 
    }

    Console.WriteLine("The sum is: " + sumNumsOnOddPos);
}

void Task38()
{
    // Задача 38: Задайте массив вещественных чисел. 
    // Найдите разницу между максимальным и минимальным 
    // элементов массива.

    int size = 5;
    double[] array = new double [size];

    FillArrayDouble(array);
    PrintArrayDouble(array);
    double maxNumber = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > maxNumber) maxNumber = array [i];
    }
    double minNumber = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }

    double differenceMaxMin = Math.Round(maxNumber - minNumber, 2);
    Console.WriteLine($"The difference btw max number {maxNumber} and min number {minNumber} = {differenceMaxMin}");
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

void PrintArrayDouble(double[] array)
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

void FillArrayDouble(double[] array)
{
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100 - 50, 2);
    }
}

void SortArray(int[] array)
{
    int size = array.Length;
    for (int i = size - 1; i > 0; i--)
    {
        for (int k = 0; k < i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] =  temp;
            }
        }
    }
}

void SumPositive(int[] array)
{
    int size = array.Length;
    int sumPos = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) sumPos += array[i];
    }

    Console.WriteLine("Sum of positive numbers = " + sumPos);
}

void SumNegative(int[] array)
{
    int size = array.Length;
    int sumNeg = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
    }

    Console.WriteLine("Sum of negative numbers = " + sumNeg);
}

void ChangePosNumToNeg(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] *= -1;
    }
}

void CountEvenNumbers(int[] array)
{
    int size = array.Length;
    int countEven = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) countEven++;
    }

    Console.WriteLine("The quantity of even numbers in the array is: " + countEven);
}

void FindMaxDouble(double[] array)
{
    int size = array.Length;
    double maxNumber = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > maxNumber) maxNumber = array [i];
    }
}

void FindMinDouble(double[] array)
{
    int size = array.Length;
    double minNumber = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }
}
//___________Main code____________________
//________________________________________
//________________________________________
//Task29A();
//Task31();
//Task32();
//Task33A();
//Task35();
//Task37A();
//Task37B();
//Task34();
//Task36();
Task38();
