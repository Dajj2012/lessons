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
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
int temp=-1;
Console.WriteLine();
for (int i=0; i<size[0];i++)
{
    for (int j=0; j<size[1];j++)
    {
        for (int j1 = 0; j1 < size[1] - 1; j1++)
        {
             if (matrix[i,j1]<matrix[i,j1+1] )
            {
                temp=matrix[i,j1];
                matrix[i,j1]=matrix[i,j1+1];
                matrix[i,j1+1]=temp;
            }
        }
       
    }
}
ExitMatrix(matrix);
