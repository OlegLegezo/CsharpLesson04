// метод печати матрицы на экран и заполнения ее числами
void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)//matrix.GetLength(0) вместо написания руками 3
{
    for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(0) вместо написания руками 4
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}
// метод печати матрицы на экран и заполнения ее числами




// метод заполнения матрицы рандомными числами
void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j]=new Random().Next(1,10);// [1;10)
    }
}
}
// метод заполнения матрицы рандомными числами


int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();//пробел
FillArray(matrix);
PrintArray(matrix);