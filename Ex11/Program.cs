Console.Clear();
Console.WriteLine("Введите колличество эллементов в массиве ");
int n =  int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i =0; i< array.Length; i++)
    array[i]= int.Parse(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", array)}]");