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
if (size[0]==size[1])
{
   Console.WriteLine("По условию задачи нужно ввести прямоугольную матрицу "); 
   return;
}
InputMatrix(matrix);
int[] result= new int[size[0]];
int kol;
for (int i=0; i<size[0];i++)
{
    kol=0;
    for (int j=0; j<size[1];j++)
    {
        kol+=matrix[i,j];
    }
    result[i]=kol;
}
int min =0;
for (int i=1; i<result.Length;i++)
{
    if(result[i]<result[min])
    min =i;
}
Console.WriteLine($"номер строки с наименьшей суммой равен:{min+1}");