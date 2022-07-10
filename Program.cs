// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void CheckingPossiblOfMultiply(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0)) System.Console.WriteLine("Перемножение невозможно.");
    else
    {

        int[,] ArraysMultiplication(int[,] array1, int[,] array2)
        {
            int[,] resultmultiplication = new int[array1.GetLength(0), array2.GetLength(1)];
            for (int i = 0; i < resultmultiplication.GetLength(0); i++)
            {
                for (int j = 0; j < resultmultiplication.GetLength(1); j++)
                {
                    for (int n = 0; n < array1.GetLength(1); n++)
                    {
                        resultmultiplication[i, j] = resultmultiplication[i, j] + array1[i, n] * array2[n, j];
                    }
                }
            }
            return resultmultiplication;
        }
        int[,] resultmultiplication = ArraysMultiplication(array1, array2);
        PrintArray(resultmultiplication);
    }
}

int row1 = Prompt("Введите количество строк в Матрице 1: ");
int column1 = Prompt("Введите количество столбцов в Матрице 1: ");
int row2 = Prompt("Введите количество строк в Матрице 2: ");
int column2 = Prompt("Введите количество столбцов в Матрице 2: ");
int min = 1;
int max = 10;
int[,] array1 = GenerateArray(row1, column1, min, max);
System.Console.WriteLine("Матрица 1:");
PrintArray(array1);
System.Console.WriteLine("Матрица 2:");
int[,] array2 = GenerateArray(row2, column2, min, max);
PrintArray(array2);
System.Console.WriteLine();
System.Console.WriteLine("Результат перемножения:");
CheckingPossiblOfMultiply(array1, array2);
