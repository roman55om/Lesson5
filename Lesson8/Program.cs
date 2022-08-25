//_____________Tasks recall block_________
//________________________________________
//________________________________________

void Task53()
{
    //Задача 53: Задайте двумерный массив. 
    //Напишите программу, которая поменяет местами 
    //первую и последнюю строку массива
    
    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];

    FillMatrix(array);
    PrintMatrix(array);

    int changePos = 0;
    int i = 0;
    for (int j = 0; j < columns; j++)
    {
        changePos = array[i,j];
        array[i,j] = array[rows-1,j];
        array[rows-1,j] = changePos;
    }

    PrintMatrix(array);
}    

void Task55()
{
    //Задача 55: Задайте двумерный массив. 
    //Напишите программу, которая заменяет строки на столбцы. 
    //В случае, если это невозможно, 
    //программа должна вывести сообщение для пользователя.

    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];

    FillMatrix(array, 1,4);
    PrintMatrix(array);

    if (rows != columns) Console.WriteLine("Interchange btw rows and columns in this array is impossible. Set the array with equal number of rows and columns.");

    else
    {
        int changePos = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                changePos = array [i,j];
                array[i,j] = array [j,i];
                array[j,i] = changePos;
            }
        }    
        PrintMatrix(array);    
    }
}
void Task57()
{
    // Задача 57: Составить частотный словарь элементов двумерного массива. 
    // Частотный словарь содержит информацию о том, 
    // сколько раз встречается элемент входных данных.

    Console.WriteLine("Enter the number of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];

    
    int startNumber = 1;
    int finishNumber = 9;
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
    PrintMatrix(array);

    int item = startNumber;
    int uniqueNums = 0;
    while (item <= finishNumber)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (item == array[i,j]) uniqueNums ++;
            }        
        }  
        item ++;     
    }
    string[] dictionary = new string[uniqueNums];

    item = 0;
    int pos = 0;
    while (item <= finishNumber)
    {
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (item == array[i,j]) 
                {
                    count ++;
                    dictionary[pos] = $"The item {item} appears in the Matrix {count} times";
                }
            }        
        }  
        pos++;        
        item ++;
    }

    PrintArrayString(dictionary);
}

void Task59()
{
    Random random = new Random();
    int rows = random.Next(4,7);
    int columns = random.Next(4,7);
    int[,] array = new int[rows,columns];
    FillMatrix(array);
    PrintMatrix(array);

    int min = array[0,0];
    int min_i = 0;
    int min_j = 0;
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i,j] < min) 
                {
                    min = array[i,j];
                    min_i = i;
                    min_j = j;
                }    
            }    
        }
    Console.WriteLine($"Min element = {min} ({min_i}, {min_j})");

    int[,] arraySecond = new int[rows-1, columns-1];
    int rowsSecond = arraySecond.GetLength(0);
    int columnsSecond = arraySecond.GetLength(1);
    int bias_i = 0;
    int bias_j = 0;

    for (int i = 0; i < rowsSecond; i++)
    {
        if (i == min_i) bias_i ++;
        bias_j = 0;
        for (int j = 0; j < columnsSecond; j++)
        {
            if (j == min_j) bias_j++;
            arraySecond[i,j] = array[i + bias_i ,j + bias_j];
        }
    }
    Console.WriteLine();
    PrintMatrix(arraySecond);
}
void Task54()
{
    // Задача 54: Задайте двумерный массив. 
    // Напишите программу, которая упорядочит
    // по убыванию элементы каждой строки двумерного массива.

    Random random = new Random();
    int rows = random.Next(3,6);
    int columns = random.Next(3,6);
    int[,] array = new int[rows,columns];
    FillMatrix(array);
    PrintMatrix(array);

    int help = 0;
    int i = 0;
    int j = 0;
    int max = array[i,j];
    int maxIndexJ = 0;
    for (i=0; i < rows; i++)
    {
        for (j = 1; j < columns; j++)
        {
            if (j>maxIndexJ && array[i,j] > max)
            {
                max = array [i,j];
                help = array[i,maxIndexJ];
                array[i,maxIndexJ] = array[i,j];
                array[i,j] = help;
                maxIndexJ = j;    
            }
        }
        
    }
    PrintMatrix(array);
}

void Task56()
{
    // Задайте прямоугольный двумерный массив. 
    //Напишите программу,
    // которая будет находить строку 
    //с наименьшей суммой элементов
    Random random = new Random();
    int rows = random.Next(3,6);
    int columns = random.Next(3,6);
    int[,] array = new int[rows,columns];
    FillMatrix(array);
    PrintMatrix(array);

    int[] sumRows = new int[rows];
    int i = 0;
    for (i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sumRows[i] += array[i,j];
        }
    }
    PrintArray(sumRows);

    i = 0;
    int min = sumRows[i];
    int minRow = i+1;
    for (i = 0; i < sumRows.Length; i++)
    {
        if (sumRows[i] < min)
        {
            min = sumRows[i];
            minRow = i+1;
        }
    }

    Console.WriteLine("The row with the lowest element sum is " + minRow);
}

void Task58()
{
    //Задача 58. Заполните спирально массив 4 на 4.

    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows,columns];
    int i = 0;
    int j = 0;   
    int filler = 1;
    
    for (; j < columns; j++)
    {
        array[i,j] = filler;
        filler ++;
    }
    
    i++;
    j--;
    for (; i<rows; i++)
    {
        array[i,j] = filler;
        filler ++;
    }

    i--;
    j--;
    for (; j >= 0; j--)
    {
        array[i,j] = filler;
        filler ++;
    }

    i--;
    j++;
    for (; i >= 0; i--)
    {
        if (array[i,j] == 0)
        {
            array[i,j] = filler;
            filler ++;
        }
    }

    i+=2;
    
    for (; j < columns; j++)
    {
        if (array[i,j] == 0)
        {
            array[i,j] = filler;
            filler ++;
        }
    }

    i++;
    j-=2;
    for (; j >= 0; j--)
    {
        if (array[i,j] == 0)
        {
            array[i,j] = filler;
            filler ++;
        }
    }
    PrintMatrix(array);
}
//___________Auxiliary method block_______
//________________________________________
//________________________________________
void PrintMatrix(int[,] array)
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

void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

void PrintArrayString(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

void FillMatrix(int[,] array, int startNumber = 0, int finishNumber = 10)
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

// int[,] CountUniqueNumsInMatrix ()
// {
//     int item = startNumber;
//     int uniqueNums = 0;
//     while (item <= finishNumber)
//     {
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 if (item == array[i,j]) uniqueNums ++;
//             }        
//         }  
//         item ++;     
//     }
//     return uniqueNums;
// }

// int[,] SetMatrix ()
// {
// Console.WriteLine("Enter the number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows,columns];
// return array;
// }
//___________Main code____________________
//________________________________________
//________________________________________
// Task53();
//Task55();
//Task57();
//Task59();
//Task54();
//Task56();
Task58();