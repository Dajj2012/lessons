void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] =Math.Round(new Random().Next(1, 100)+new Random().NextDouble(),3); 
}
double MaxArray(double[] array)
{
    double max=array[0];
    for (int i = 1; i < array.Length; i++)
    if (array[i]>max)
    max=array[i];
    return max;
}
double MinArray(double[] array)
{
    double min=array[0];
    for (int i = 1; i < array.Length; i++)
    if (array[i]<min)
    min=array[i];
    return min;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"{MaxArray(array)}-{MinArray(array)}={MaxArray(array)-MinArray(array)}");