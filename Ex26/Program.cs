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

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
for (int i=0; i<size[0];i++)
{
    for (int j=0; j<size[1];j++)
    {
        Console.WriteLine();
        for (int k=0; k<size[2];k++)
        {
            Console.Write($"{matrix[i,j,k]} ({i+1},{j+1},{k+1}) ");
        }
    }
}