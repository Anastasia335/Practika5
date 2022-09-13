// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} ");
}
Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = new Random().Next(1,10);
}
}
}
Console.Write("Введите колличество строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[str, stolb]; 
Console.Write("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

if (a < matrix.GetLength(0) && b < matrix.GetLength(1)) 
    Console.WriteLine( $"Элемент с индексами [{a},{b}] -> {matrix[a, b]}");
else 
    Console.WriteLine( $"Элемента с индексами [{a},{b}] в данном массиве нет");