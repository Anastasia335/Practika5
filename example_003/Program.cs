// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
Console.Write("Введите колличество строк:");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов:");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[str, stolb];
Console.WriteLine();
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sred = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sred = (sred + matrix[i, j]);
    }
    sred = sred / str;
    Console.Write(Math.Round(sred, 2) + "; ");
}
