// Написать программу, которая обменивает элементы первой строки и последней строки


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
int[,] ChangeElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int value = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = value;
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int row = 5;
int col = 5;
int min = 1;
int max = 10;

int[,] array = GetArray(row, col, min, max);
PrintArray(array);
System.Console.WriteLine();
int[,] array2 = ChangeElements(array);
PrintArray(array2);
