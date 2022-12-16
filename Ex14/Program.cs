void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); 
}

Console.Clear();
int k =0;
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i =0; i< array.Length; i++)
{
    if (array[i]%2==0)
    k++;
}
Console.WriteLine(k);