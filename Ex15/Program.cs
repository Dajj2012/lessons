void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100); 
}

int summ1(int[] array)
{
    int summ=0;
    for (int i =0; i< array.Length; i++)
    if (i%2!=0)
    summ+=array[i];
    return summ;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.Write(summ1(array));
