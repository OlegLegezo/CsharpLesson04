//мтарица чисел
int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)//matrix.GetLength(0) вместо написания руками 3
{
    for (int j = 0; j < matrix.GetLength(1); j++)//matrix.GetLength(0) вместо написания руками 4
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}