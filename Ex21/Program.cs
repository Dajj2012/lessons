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
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
double[] result= new double[size[1]];
double kol;
for (int i=0; i<size[1];i++)
{
    kol=0;
    for (int j=0; j<size[0];j++)
    {
        kol+=matrix[j,i];
    }
    result[i]=Math.Round(kol/size[0],2);
}
Console.WriteLine($"[{string.Join(", ", result)}]");