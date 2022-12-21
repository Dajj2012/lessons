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

Console.Write("Введите адрес искомого эллемента: ");
int[] poisk = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if ((poisk[0] > size[0]) || (poisk[1] > size[1]))
    {
    Console.Write("такой позиции в массиве нет ");
    }
else
    {
    Console.Write(matrix[poisk[0]-1,poisk[1]-1]);
    }