// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введитче число рядов: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int colCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Несортированный массив: ");

int[,] table = new int[rowCount, colCount];
var element = new Random();
for (int a = 0; a < rowCount; a++)
{
    for (int b = 0; b < colCount; b++)
    {
        table[a, b] = element.Next(0, 9);
        Console.Write($"{table[a, b]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
        row[j] = table[i, j];
    BubbleSort(row);
    Insert(true, i, row, table);
}
PrintArray(table);

void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}
void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}