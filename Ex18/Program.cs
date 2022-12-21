void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = int.Parse(Console.ReadLine()); 
}
Console.Clear();
Console.WriteLine("Введите число ");
int n =  int.Parse(Console.ReadLine());
int[] array = new int[n];
int kol=0;
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i=0; i<array.Length; i++)
{
    if (array[i]>0)
    kol++;
}
Console.WriteLine($"колличество эллементов больше нуля: {kol}");