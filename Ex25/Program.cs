void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 101); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ExitMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                        Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры матрицы 1: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.Write("Введите размеры матрицы 2: ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
if(size1[1]!=size2[0])
{
    Console.Write("Произведения матриц не существует");
    return;
}
InputMatrix(matrix1);
Console.WriteLine();
InputMatrix(matrix2);
int[,] matrix3 = new int[size1[0],size2[1]];

for (int i=0; i<size1[0];i++)
{
    for (int j=0; j<size2[1];j++)
    {
        matrix3[i,j]=0;
        for (int k=0; k<size1[1]; k++)
        matrix3[i,j]=matrix1[i,k]*matrix2[k,j];
    }
}
Console.WriteLine();
ExitMatrix(matrix3);

