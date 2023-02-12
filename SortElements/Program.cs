// Написать программу, упорядочевания по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[,] SortElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;    
            }
            int a = array[i, j];                                          
            array[i, j] = array[i, minPosition];                            
            array[i, minPosition] = a;                                    
        }
    }
    return array;
}

void PrintTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int row = 5;
int col = 5;
int min = 1;
int max = 10;

int[,] table = GetArray(row, col, min, max);
PrintTable(table);

System.Console.WriteLine();
int[,] rowSort = SortElements(table);
PrintTable(rowSort);
