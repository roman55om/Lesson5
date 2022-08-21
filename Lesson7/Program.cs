//_____________Tasks recall block_________
//________________________________________
//________________________________________

void Task48()
{
    // Задача 48: Задайте двумерный массив размера m на n, 
    // каждый элемент в массиве находится по формуле: A = i+j. 
    // Выведите полученный массив на экран.

    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i+j;
        }
    }    

    PrintArray(array);

}

void Task49()
{
    //Задача 49: Задайте двумерный массив. 
    //Найдите элементы, у которых оба индекса чётные, 
    //и замените эти элементы на их квадраты.

    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
    
    FillArray(array, 4,8);
    PrintArray(array);

    for (int i = 0; i < rows; i +=2)
    {
        for (int j = 0; j < columns; j +=2)
        {
            array[i,j] *= array[i,j];
        }
    }
    Console.WriteLine();
    PrintArray(array);
}

void Task51()
{
    //Задача 51: Задайте двумерный массив.
    // Найдите сумму элементов, 
    //находящихся на главной диагонали 
    //(с индексами (0,0); (1;1) и т.д. 

    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];

    FillArray(array, 1,5);
    PrintArray(array);

    int sum = 0;
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            if (i == j) sum += array[i,j];
        }   
    }
    Console.WriteLine(sum);
}

void Task47()
{
    //Задача 47. Задайте двумерный массив размером m×n, 
    //заполненный случайными вещественными числами.

    Random random = new Random();
    int rows = random.Next(4,9);
    int columns = random.Next(4,9);
    double[,] array = new double[rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 100 - 50, 1);
        }
    }    

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }    
}

void Task50()
{
    // Задача 50. Напишите программу, 
    // которая на вход принимает позиции элемента 
    // в двумерном массиве, и возвращает значение
    // этого элемента или же указание, что такого элемента нет.

    Random random = new Random();
    int rows = random.Next(4,9);
    int columns = random.Next(4,9);
    int[,] array = new int[rows,columns];

    FillArray(array);
    PrintArray(array);
    ChooseElementInMatrix(array);
}

void Task52()
{
    // Задача 52. Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.

    Random random = new Random();
    int rows = random.Next(4,9);
    int columns = random.Next(4,9);
    int[,] array = new int[rows,columns];

    FillArray(array);
    PrintArray(array);

    for (int j = 0; j < columns; j++)
    {
        double result = 0;
        for (int i = 0; i < rows; i++)
        {
            result += array[i,j];    
        }
        result = Math.Round(result/rows, 2);
        Console.WriteLine($"The average of the {j+1} column is {result}");
    }    
}
//___________Auxiliary method block_______
//________________________________________
//________________________________________
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }    
    Console.WriteLine();   
}

void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber ++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }    
}

void ChooseElementInMatrix(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine("Enter the desired coordinates (x,y)");
    int j = Convert.ToInt32(Console.ReadLine());
    int i = Convert.ToInt32(Console.ReadLine());
    if (i > rows || j > columns) Console.WriteLine("The element with selected coordinates is beyond the array range");
    else
    {
        Console.WriteLine($"The element with coordinates {(j,i)} is {array[i-1, j-1]}");
    }
}

// void SetMatrix (int rows, int columns, int[,] array)
// {
//     Console.WriteLine("Enter the number of rows");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the number of columns");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows,columns];
//     return rows;
//     return columns;
//     return array;
// }
//___________Main code____________________
//________________________________________
//________________________________________
//Task48();
//Task49();
//Task51();
//Task47();
//Task50();
//Task52();